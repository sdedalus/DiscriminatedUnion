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
  let projects = !! "src/**/*.csproj" -- "src/**/*.Tests.csproj"
  let testProjects = !! "src/**/*Tests.csproj"
  let packages = !! "./**/packages.config"

  let solution = !! "*.sln" 


  let getOutputDir proj =
    let folderName = Directory.GetParent(proj).Name
    sprintf "%s%s/" buildDir folderName

  let build proj =
    let outputDir = proj |> getOutputDir
    MSBuildRelease outputDir "Build" [proj] 
    |> Log "Build-Output: "

  let getVersion() =
    let buildCandidate = (environVar "APPVEYOR_BUILD_NUMBER")
    if buildCandidate = "" || buildCandidate = null then "1.0.0" else (sprintf "1.0.0.%s" buildCandidate)

[<AutoOpen>]
module Targets =
  Target "Clean" (fun() ->
    CleanDirs [buildDir; deployDir; testDir]
  )

  Target "RestorePackages" (fun _ ->
    packages
    |> Seq.iter (RestorePackage (fun p -> {p with OutputPath = "./packages"}))
  )

  // Target "Build" (fun() ->
  //   projects
  //   |> Seq.iter build
  
  Target "Build" (fun() ->
    MSBuildRelease buildDir "Build" solution
    |> ignore
  )
    
  Target "BuildTest" (fun() ->
    testProjects
    |> MSBuildDebug testDir "Build"
    |> ignore
  )

  Target "CopyMain" (fun _ ->
    let targetDir = packagingDir @@ "main"
    let sourceFile = buildDir + "DiscriminatedUnion.dll"
    CreateDir targetDir
    CopyFile targetDir sourceFile 
  )

  Target "CopyJson" (fun _ ->
    let targetDir = packagingDir @@ "json"
    let sourceFile = buildDir + "DiscriminatedUnionJsonConverter.dll"
    CreateDir targetDir
    CopyFile targetDir sourceFile
  )

  Target "CopyAuto" (fun _ ->
    let targetDir = packagingDir @@ "automap"
    let sourceFile = buildDir + "DiscriminatedUnionAutoMap.dll"
    CreateDir targetDir
    CopyFile targetDir sourceFile
  )

  Target "Test" (fun() ->
    !!(testDir @@ "*Tests.dll")
        |> xUnit2 (fun p ->
            {p with
                ShadowCopy = false;
                HtmlOutputPath = Some (testDir @@ "xunit.html");
                XmlOutputPath = Some (testDir @@ "xunit.xml");
            })
  )

  Target "PackageMain" (fun _ ->
    trace "Packing"
    let version = getVersion()
    NuGet (fun p ->
          {p with
              Project = "DiscriminatedUnion"
              Authors = ["David Lewis"]              
              Description = "Discriminated Union"
              OutputPath = deployDir
              Summary = "Discriminated Union with Fluent Matching written for C#"
              WorkingDir = packagingDir  @@ "main"
              Files = [(buildDir + "DiscriminatedUnion/DiscriminatedUnion.dll", None, None)]
              Version = version
              Publish = false              
              })
              ("src/DiscriminatedUnion/DiscriminatedUnion.nuspec")
  )

  Target "PackageJson" (fun _ ->
    trace "Packing"
    let version = getVersion()
    NuGet (fun p ->
          {p with
              Project = "DiscriminatedUnionJsonConverter"
              Authors = ["David Lewis"]
              Description = "Discriminated Union Json Helper"
              OutputPath = deployDir
              Dependencies = 
                [
                  ("DiscriminatedUnion",  version) 
                  ("Newtonsoft.Json", "10.0.3")]
              Summary = "Discriminated Union with Fluent Matching written for C#"
              WorkingDir = packagingDir @@ "json"
              Files = [(buildDir @@ "DiscriminatedUnionJsonConverter/DiscriminatedUnionJsonConverter.dll", None, None)]
              Version = version
              Publish = false })
              ("src/DiscriminatedUnionJsonConverter/DiscriminatedUnionJsonConverter.nuspec")
  )

  Target "PackageAutoMap" (fun _ ->
    trace "Packing"
    let version = getVersion()
    NuGet (fun p ->
          {p with
              Project = "DiscriminatedUnionAutoMap"
              Authors = ["David Lewis"]
              Description = "Discriminated Union AutoMap Helper"
              OutputPath = deployDir
              Dependencies = 
                [
                  ("DiscriminatedUnion",  version) 
                  ("AutoMapper", "6.1.0")]
              Summary = "Discriminated Union with Fluent Matching written for C#"
              WorkingDir = packagingDir @@ "automap"
              Files = [(buildDir @@ "DiscriminatedUnionAutoMap/DiscriminatedUnionAutoMap.dll", None, None)]
              Version = version
              Publish = false })
              ("src/DiscriminatedUnionAutoMap/DiscriminatedUnionAutoMap.nuspec")
  )

  Target "Default" (fun _ -> ())
  
"Clean"
==> "RestorePackages"
==> "Build"
//==> "BuildTest"
//==> "Test"
==> "CopyMain"
==> "CopyJson"
==> "CopyAuto"
==> "PackageMain"
==> "PackageJson"
==> "PackageAutoMap"
==> "Default"

RunTargetOrDefault "Default"