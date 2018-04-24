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
    DotNetCli.Restore(fun p -> { p with NoCache = true }) |> ignore
  )
  
  Target "Build" (fun() ->
    DotNetCli.Build (fun p -> { p with Configuration = "Release"; Output = buildDir }) |> ignore

    DotNetCli.Pack (fun p -> { p with Configuration = "Release"; OutputPath = deployDir }) |> ignore
  )
  
  Target "BuildTest" (fun() ->
     CreateDir testDir
     DotNetCli.Build (fun p -> { p with Configuration = "Debug"; Output = testDir }) |> ignore
  )
    
  Target "Test" (fun() ->
     DotNetCli.Test |> ignore
  )

  Target "CopyMain" (fun _ ->
    CreateDir deployDir
    CopyDir deployDir buildDir (fun x -> x.Contains(".nupkg"))
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
==> "BuildTest"
==> "Test"
==> "Build"
==> "CopyMain"
==> "DeployNuGet"
==> "Default"

RunTargetOrDefault "Default"