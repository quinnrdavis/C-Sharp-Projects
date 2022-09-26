using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Methods
    {
        // method with optional j parameter
        public int MathMethod(int i, int j = 5)
        {
            return i * j;
        }
    }
}
