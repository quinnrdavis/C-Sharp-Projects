using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Ints
{
    class Program
    {
        static void Main(string[] args)
        {
            // list of ints to be divided
            List<int> numberList = new List<int>() { 4, 8, 15, 16, 23, 42 };
            // ask for input number
            Console.WriteLine("Please enter a number to divide each number in the list by:");

            try
            {
                // cast input to int
                int input = Convert.ToInt32(Console.ReadLine());

                // divide each number in the list by the input number, print result to screen
                foreach (int number in numberList)
                {
                    Console.WriteLine(number / input);
                }                
            } catch (Exception ex)
            // if exception, print message
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("The try catch block has finished");

            Console.Read();
        }
    }
}
