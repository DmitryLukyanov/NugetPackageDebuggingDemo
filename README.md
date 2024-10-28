# Core/Latest frameworks
## Link: https://lurumad.github.io/using-source-link-in-net-projects-and-how-to-configure-visual-studio-to-use-it
## Commands:

1. dotnet pack .\NugetPackageDebuggingDemo.csproj -c Release -o .\artifacts --include-symbols
2. ls
PS C:\Git\NugetPackageDebuggingDemo\NugetPackageDebuggingDemo\artifacts> ls


    Directory: C:\Git\NugetPackageDebuggingDemo\NugetPackageDebuggingDemo\artifacts


Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
-a----        10/28/2024   5:39 PM           3641 NugetPackageDebuggingDemo.1.0.0.nupkg
-a----        10/28/2024   5:39 PM           8425 NugetPackageDebuggingDemo.1.0.0.snupkg
3. nuget push .\NugetPackageDebuggingDemo.1.0.0.nupkg 
-Source https://api.nuget.org/v3/index.json 
-ApiKey API_KEY_