using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for input
            Console.WriteLine("Please input a number:");
            // cast input to int
            int input = Convert.ToInt32(Console.ReadLine());

            // instantiate object
            MethodClass methods = new MethodClass();

            // print result of each method
            Console.WriteLine(methods.Addition(input) + "\n" + methods.Subtraction(input) + "\n" + methods.Multiplication(input));

            Console.Read();
        }
    }
}
