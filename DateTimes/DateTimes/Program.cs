using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // print current time
            Console.WriteLine(DateTime.Now);

            // ask user for a number
            Console.WriteLine("Please enter a number: ");
            // cast input to int
            int input = Convert.ToInt32(Console.ReadLine());
            // add input as hours to current time
            DateTime dt = DateTime.Now.AddHours(input);
            // print result
            Console.WriteLine(dt);

            Console.Read();
        }
    }
}
