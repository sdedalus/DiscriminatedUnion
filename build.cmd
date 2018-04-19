@echo off
cls  
NuGet.exe "Install" "FAKE" "-OutputDirectory" "packages" "-ExcludeVersion" 
dotnet restore 
"packages\FAKE\tools\Fake.exe" build.fsx %*