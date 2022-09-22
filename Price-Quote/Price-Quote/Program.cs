using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote
{
    class Program
    {
        static int Main(string[] args)
        {
            // print greeting
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // ask for weight
            Console.WriteLine("Please enter the package weight:");
            // cast input to int
            int weight = Convert.ToInt32(Console.ReadLine());
            // if weight is greater than 50, give response and exit program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                return -1;
            }

            // ask for width
            Console.WriteLine("Please enter the package width:");
            // cast input to int
            int width = Convert.ToInt32(Console.ReadLine());

            // ask for height
            Console.WriteLine("Please enter the package height:");
            // cast input to int
            int height = Convert.ToInt32(Console.ReadLine());

            // ask for length
            Console.WriteLine("Please enter the package length:");
            // cast input to int
            int length = Convert.ToInt32(Console.ReadLine());

            // calculate price quote as decimal because it might not be a whole number
            decimal quote = ((width * height * length) * weight) / 100m;

            // print message with quote converted to money format
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("C"));

            Console.Read();

            return -1;
        }
    }
}
