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

            // get input from user
            Console.WriteLine("Please enter a number: ");

            // cast input to int
            int input = Convert.ToInt32(Console.ReadLine());

            // declare variable to hold output parameter
            int output;
            // call method, store output in output variable
            class1.Method1(input, out output);

            // print output parameter
            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
