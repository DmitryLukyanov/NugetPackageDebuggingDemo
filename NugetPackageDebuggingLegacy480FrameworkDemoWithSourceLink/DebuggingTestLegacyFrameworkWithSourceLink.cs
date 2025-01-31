using System.Diagnostics;

namespace NugetPackageDebuggingLegacy480FrameworkDemoWithSourceLink
{
    public class DebuggingTestLegacyFrameworkWithSourceLink
    {
        public void Test()
        {
        }

        public void TestWithDebugger()
        {
            Debugger.Break();
        }

        public void OnlyInLegacySymbolsPackageAndSourceLink()
        {
        }
    }
}
