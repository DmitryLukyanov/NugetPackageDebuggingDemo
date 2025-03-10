using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_NET461_V4
{
    public class DebuggingTestLegacyFramework461_v4
    {
        public void Test2()
        {
            new ClassLibrary_InnerProject.Class3().TestWithDebugger3();
        }

        public void TestWithDebugger()
        {
            Debugger.Break();
        }
    }
}
