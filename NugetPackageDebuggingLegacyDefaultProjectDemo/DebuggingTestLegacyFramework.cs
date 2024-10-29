using System.Diagnostics;

namespace NugetPackageDebuggingLegacyFrameworkDemo
{
    public class DebuggingTestLegacyFrameworkDefault
    {
        public void Test()
        {
        }

        public void TestWithDebugger()
        {
            Debugger.Break();
        }
    }
}
