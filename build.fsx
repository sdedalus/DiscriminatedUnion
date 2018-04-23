// include Fake lib
#r @"packages/FAKE/tools/FakeLib.dll"
open Fake
open Fake.Testing
open Fake.Testing.XUnit2
open Fake.AppVeyor
open Fake.NuGetHelper
open System.IO

[<AutoOpen>]
module Settings =
  let buildDir = "./.build/"
  let packagingDir = buildDir + "BuildOutput/"
  let deployDir = "./.deploy/"
  let testDir = "./.test/"
  let projects = !! "**/*.csproj" -- "**/*.Tests.csproj"
  let testProjects = !! "**/*Tests.csproj"
  let packages = !! "./**/packages.config"

  let solution = !! "*.sln" 
  
  let nuGetApiKey = environVar "nuget_api_key"

  let getOutputDir proj =
    let folderName = Directory.GetParent(proj).Name
    sprintf "%s%s/" buildDir folderName

  let build proj =
    let outputDir = proj |> getOutputDir
    MSBuildRelease outputDir "Build" [proj] 
    |> Log "Build-Output: "
  
  let getVersion() =
    let buildCandidate = (environVar "APPVEYOR_BUILD_NUMBER")
    if buildCandidate = "" || buildCandidate = null then "2.0.0" else (sprintf "2.0.0.%s" buildCandidate)

[<AutoOpen>]
module Targets =
  Target "Clean" (fun() ->
    CleanDirs [buildDir; deployDir; testDir]
  )

  Target "RestorePackages" (fun _ ->
    "DiscriminatedUnion.sln"
     |> RestoreMSSolutionPackages (fun p ->
         { p with
             Sources = "https://api.nuget.org/v3/index.json" :: p.Sources
             OutputPath = "packages"
             Retries = 4 })
  )

  // Target "Build" (fun() ->
  //   projects
  //   |> Seq.iter build
  
  Target "Build" (fun() ->
    MSBuildRelease buildDir "Build" solution
    |> ignore
  )
  
  Target "BuildTest" (fun() ->
     
    MSBuild testDir "Build" [ "Configuration", "Test" ] solution
    |> ignore
  )

  Target "CopyMain" (fun _ ->
    let targetDir = deployDir
    CreateDir targetDir
    CopyDir targetDir buildDir (fun x -> x.EndsWith(".nupkg"))
    //sourceFiles |> Seq.iter (CopyFile targetDir) 
  )
  
  Target "DeployNuGet" (fun _ ->
    let version = getVersion()
    let nuGetUrl = "https://nuget.org"

    NuGetPublish (fun nugetParams -> 
      { nugetParams with
          AccessKey = nuGetApiKey
          PublishUrl = nuGetUrl
          Project = "DiscriminatedUnion.Core"
          Version = version
          WorkingDir = deployDir 
          OutputPath = deployDir 
      }
    )

    NuGetPublish (fun nugetParams -> 
      { nugetParams with
          AccessKey = nuGetApiKey
          PublishUrl = nuGetUrl
          Project = "DiscriminatedUnion.AutoMap"
          Version = version
          WorkingDir = deployDir
          OutputPath = deployDir
      }
    )

    NuGetPublish (fun nugetParams -> 
      { nugetParams with
          AccessKey = nuGetApiKey
          PublishUrl = nuGetUrl
          Project = "DiscriminatedUnion.Json"
          Version = version
          WorkingDir = deployDir
          OutputPath = deployDir
      }
    )
  )

  Target "Default" (fun _ -> ())
  
"Clean"
//==> "RestorePackages"
==> "Build"
//==> "BuildTest"
//==> "Test"
==> "CopyMain"
==> "DeployNuGet"
==> "Default"

RunTargetOrDefault "Default"