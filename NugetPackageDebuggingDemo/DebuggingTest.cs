using System.Diagnostics;

namespace NugetPackageDebuggingDemo
{
    public class DebuggingTest
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
