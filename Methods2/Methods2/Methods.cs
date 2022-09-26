using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Methods
    {
        // method that adds 5 to input
        public int MathMethod(int i)
        {
            return i + 5;
        }

        // method with the same name that takes a decimal input
        public int MathMethod(decimal d)
        {
            // cast input to int
            int i = Convert.ToInt32(d);

            return i - 12;
        }

        // method with the same name that takes a string input
        public int MathMethod(string s)
        {
            // cast input to int if possible
            int i = Convert.ToInt32(s);

            return i * 4;
        }
    }
}
