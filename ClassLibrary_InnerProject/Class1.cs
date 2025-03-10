using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_InnerProject
{
    public class Class3
    {
        public void TestWithDebugger3()
        {
            Debugger.Break();
            var client = new MongoDB.Driver.MongoClient();
        }
    }
}
