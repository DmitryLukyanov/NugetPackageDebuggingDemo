using System.Diagnostics;

namespace NugetPackageDebuggingLegacy480FrameworkDemoWithSourceLinkAndDefaultConfiguration
{
    public class DebuggingTestLegacyFramework
    {
        public void Test()
        {
        }

        public void TestWithDebugger()
        {
            Debugger.Break();
        }

        public void OnlyInLegacySymbolsPackage()
        {
        }
    }
}
