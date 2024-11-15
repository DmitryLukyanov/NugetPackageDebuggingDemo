# Core/Latest frameworks
## Link: https://lurumad.github.io/using-source-link-in-net-projects-and-how-to-configure-visual-studio-to-use-it
## Commands (NugetPackageDebuggingDemo project):

1. 

        dotnet pack .\NugetPackageDebuggingDemo.csproj -c Release -o .\artifacts --include-symbols

2. ls

        PS C:\Git\NugetPackageDebuggingDemo\NugetPackageDebuggingDemo\artifacts> ls

             Directory: C:\Git\NugetPackageDebuggingDemo\NugetPackageDebuggingDemo\artifacts
 
 
        Mode                 LastWriteTime         Length Name
        ----                 -------------         ------ ----
       -a----        10/28/2024   5:39 PM           3641 NugetPackageDebuggingDemo.1.0.0.nupkg
       -a----        10/28/2024   5:39 PM           8425 NugetPackageDebuggingDemo.1.0.0.snupkg

3. 

      nuget push .\NugetPackageDebuggingDemo.1.0.0.nupkg 
        -Source https://api.nuget.org/v3/index.json 
        -ApiKey API_KEY

# Other tried and that doesn't work without additional configuration

>[!WARNING]
> If producing and consuming nugets happen on the same machine, it might be that additional configuration in the solution won't be required due to some "local cache" configuration. But when consuming happens on another machine, debug source configuration in the solution file will be mandatory.

## Non SDK project and 4.5.2 / 4.8 monikers (NugetPackageDebuggingLegacy480FrameworkDemo project)

0. Project file:

        <TargetFrameworkVersion>v4.8</TargetFrameworkVersion>
        <DebugSymbols>true</DebugSymbols>
        <DebugType>portable</DebugType>


1. With `-Symbols` and `-SymbolPackageFormat snupkg`

        nuget pack -IncludeReferencedProjects -Symbols -Build -OutputDirectory "artifacts" -SymbolPackageFormat snupkg

Pay attention on `-SymbolPackageFormat snupkg`

2. 

        cd .\artifacts\ 

3. 

        PS C:\Git\NugetPackageDebuggingDemo\NugetPackageDebuggingLegacy480FrameworkDemo\artifacts> ls


            Directory: C:\Git\NugetPackageDebuggingDemo\NugetPackageDebuggingLegacy480FrameworkDemo\artifacts


        Mode                 LastWriteTime         Length Name
        ----                 -------------         ------ ----
        -a----        10/29/2024   1:34 PM           3691 NugetPackageDebuggingLegacy480FrameworkDemo.1.0.0.nupkg
        -a----        10/29/2024   1:34 PM           3142 NugetPackageDebuggingLegacy480FrameworkDemo.1.0.0.snupkg

4.  
 
        nuget push .\NugetPackageDebuggingLegacy480FrameworkDemo.1.0.0.nupkg -Source https://api.nuget.org/v3/index.json -ApiKey API_KEY

### Result
The package and symbol server have been deployed to nuget.org. 
NOTE: no pdb file found

To allow debugging, do the following: 
1. Open solution settings in the consumer solution
2. Checked out the project that produced the nuget packages with right version of the code
3. Go to Common properties => Debug Source Files
![DebugSourceFileConfiguration](DebugSourceFileConfiguration.png)
4. Add the path to the solution folder into "Directory containing source code".
5. Click ok

## Non SDK Project and default project configuration (NugetPackageDebuggingLegacyDefaultProjectDemo project)

1. With only `-Symbols`

        nuget pack -IncludeReferencedProjects -Symbols -Build -OutputDirectory "artifacts"  -Version 4.0.0

2. 
 
        ls

        >     Directory: ..
        > 
        > 
        > Mode                 LastWriteTime         Length Name
        > ----                 -------------         ------ ----
          > -a----        10/29/2024   4:44 PM           7106 NugetPackageDebuggingLegacyDefaultProjectDemo.4.0.0.symbols.nupkg

3. 

        nuget push .\NugetPackageDebuggingLegacyDefaultProjectDemo.4.0.0.symbols.nupkg -Source https://api.nuget.org/v3/index.json -ApiKey API_KEY

### Result
Same as above, but pdb file is added to the bin folder. But configuring a source files in solution is still required
