using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate class
            Methods methods = new Methods();

            // call method with both parameters
            methods.MathMethod(4, 6);

            // call method with parameters by name
            methods.MathMethod(i:5, j:3);
        }
    }
}
