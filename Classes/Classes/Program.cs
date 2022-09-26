using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate class
            Class1 class1 = new Class1();

            // declare variable to hold output parameter
            int output;
            // call method, store output in output variable
            class1.Method1(6, out output);

            // print output parameter
            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
