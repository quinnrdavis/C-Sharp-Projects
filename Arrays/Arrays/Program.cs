using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize array of strings
            string[] strings = new string[] { "this", "is", "an", "array" };
            // initialize input variable
            int i;

            do
            {
                // ask for a number 0-3
                Console.WriteLine("Select an index from 0-3");
                // cast input to int
                i = Convert.ToInt32(Console.ReadLine());
                // check if index is in range
                if (i < 0 || i > 3)
                {
                    // give error message
                    Console.WriteLine("Invalid index");
                } else
                {
                    // display string at given index
                    Console.WriteLine(strings[i]);
                }
                
            }
            // if input is in range stop the loop
            while (i < 0 || i > 3);
            

            // initialize array of integers
            int[] nums = new int[] { 4, 8, 15, 16, 23, 42 };
            // initialize input variable
            int j;

            do
            {
                // ask for a number 0-5
                Console.WriteLine("Select an index from 0-5");
                // cast input to int
                j = Convert.ToInt32(Console.ReadLine());
                // check if index is in range
                if (j < 0 || j > 5)
                {
                    // give error message
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    // display integer at given index
                    Console.WriteLine(nums[j]);
                }

            }
            // if input is in range stop the loop
            while (j < 0 || j > 5);

            // initialize list of strings
            List<string> stringsList = new List<string>();
            // populate list of strings
            stringsList.Add("this");
            stringsList.Add("is");
            stringsList.Add("a");
            stringsList.Add("list");
            stringsList.Add("of");
            stringsList.Add("strings");
            // ask for an number 0-5
            Console.WriteLine("Select an index from 0-5");
            // cast input to int
            int k = Convert.ToInt32(Console.ReadLine());
            // display selected string
            Console.WriteLine(stringsList[k]);


            Console.Read();
        }
    }
}
