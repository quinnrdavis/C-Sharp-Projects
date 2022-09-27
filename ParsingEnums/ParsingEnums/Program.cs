using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        // define enum for days of the week
        enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            // prompt user to enter current day of the week
            Console.WriteLine("Please enter the current day of the week: ");
            // store input as string
            string input = Console.ReadLine();

            // declare variable for enum value
            DaysOfTheWeek day;

            // try converting the string input to enum type and assigning it to the day variable
            try
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
            } catch
            // if it does not work print message
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
