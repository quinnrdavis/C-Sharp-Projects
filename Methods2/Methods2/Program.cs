using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate an object of methods class
            Methods methods = new Methods();

            // method with int input
            Console.WriteLine(methods.MathMethod(5));

            // method with decimal input
            Console.WriteLine(methods.MathMethod(5.000m));

            // method with string input
            Console.WriteLine(methods.MathMethod("5"));

            Console.Read();
        }
    }
}
