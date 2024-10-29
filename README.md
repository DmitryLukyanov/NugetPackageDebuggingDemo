# Core/Latest frameworks
## Link: https://lurumad.github.io/using-source-link-in-net-projects-and-how-to-configure-visual-studio-to-use-it
## Commands:

1. dotnet pack .\NugetPackageDebuggingDemo.csproj -c Release -o .\artifacts --include-symbols
2. ls
PS C:\Git\NugetPackageDebuggingDemo\NugetPackageDebuggingDemo\artifacts> ls

>     Directory: C:\Git\NugetPackageDebuggingDemo\NugetPackageDebuggingDemo\artifacts
> 
> 
> Mode                 LastWriteTime         Length Name
> ----                 -------------         ------ ----
> -a----        10/28/2024   5:39 PM           3641 NugetPackageDebuggingDemo.1.0.0.nupkg
> -a----        10/28/2024   5:39 PM           8425 NugetPackageDebuggingDemo.1.0.0.snupkg

3. nuget push .\NugetPackageDebuggingDemo.1.0.0.nupkg 
-Source https://api.nuget.org/v3/index.json 
-ApiKey API_KEY

# Other tried and that doesn't work
## Non SDK project and 4.5.2 / 4.8 monikers
0. 

    <TargetFrameworkVersion>v4.8</TargetFrameworkVersion>
	<DebugSymbols>true</DebugSymbols>
    <DebugType>portable</DebugType>


1. nuget pack -IncludeReferencedProjects -Symbols -Build -OutputDirectory "artifacts" -SymbolPackageFormat snupkg

Pay attention on `-SymbolPackageFormat snupkg`

2. cd .\artifacts\ 
3. PS C:\Git\NugetPackageDebuggingDemo\NugetPackageDebuggingLegacy480FrameworkDemo\artifacts> ls


    Directory: C:\Git\NugetPackageDebuggingDemo\NugetPackageDebuggingLegacy480FrameworkDemo\artifacts


Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
-a----        10/29/2024   1:34 PM           3691 NugetPackageDebuggingLegacy480FrameworkDemo.1.0.0.nupkg
-a----        10/29/2024   1:34 PM           3142 NugetPackageDebuggingLegacy480FrameworkDemo.1.0.0.snupkg

Project file:

4.  nuget push .\NugetPackageDebuggingLegacy480FrameworkDemo.1.0.0.nupkg -Source https://api.nuget.org/v3/index.json -ApiKey API_KEY

### Result
The package and symbol server have been deployed to nuget.org. 
NOTE: no pdb file found

To allow debugging, do the following: 
1. Open solution settings in the consumer solution
2. Checked out the project that produced the nuget packages with right version of the code
3. Go to Common properties => Debug Source Files 
4. Add the path to the solution folder into "Directory containing source code".
5. Click ok