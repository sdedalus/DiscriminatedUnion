@echo off
cls  
rd /s /q packages
NuGet.exe "Install" "FAKE" "-OutputDirectory" "packages" "-ExcludeVersion" 
dotnet restore 
"packages\FAKE\tools\Fake.exe" build.fsx %*