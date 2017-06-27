@echo off
cls  
NuGet.exe "Install" "FAKE" "-OutputDirectory" "packages" "-ExcludeVersion" 
NuGet.exe "Install" "xunit.runner.console" "-OutputDirectory" "tools" "-ExcludeVersion" 

"packages\FAKE\tools\Fake.exe" build.fsx %*