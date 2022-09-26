using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate class
            Methods methods = new Methods();

            // instructional message
            Console.WriteLine("Please input two numbers, one at a time. The second number is optional.\nFirst Number: ");

            // cast input to int
            int input = Convert.ToInt32(Console.ReadLine());

            // ask for optional second number
            Console.WriteLine("Now the optional second number: ");
            
            // store input
            string input2 = Console.ReadLine();

            // if input2 is empty, call method with one parameter
            if (input2 == "")
            {
                Console.WriteLine(methods.MathMethod(input));
            } else
            // if input2 is not empty, cast to int and call method with both parameters
            {
                int input2Int = Convert.ToInt32(input2);
                Console.WriteLine(methods.MathMethod(input, input2Int));
            }

            Console.Read();
        }
    }
}
