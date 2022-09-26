using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Class1
    {
        // void method with output parameter
        public void Method1(int i, out int output)
        {
            output = i / 2;
        }

        // overloaded method with output parameter
        public void Method1(int i, out int output, int j = 1)
        {
            output = i + j;
        }
    }
}
