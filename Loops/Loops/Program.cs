using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize both variables
            int num1 = 0;
            int num2 = 2;

            // while loop that prints out numbers 0 through 10 and stops at 10
            while (num1 <= 10)
            {
                Console.WriteLine(num1);
                num1++;
            }

            // do while loop that prints successive powers of 2 until the next one would be greater than 20000
            do
            {
                Console.WriteLine(num2);
                num2 += num2;
            }
            while (num2 < 20000);
            Console.Read();
        }
    }
}
