using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print greeting
            Console.WriteLine("Anonymous Income Comparison Program");
            // Person 1
            // hourly rate
            Console.WriteLine("Person 1\nHourly Rate: ");
            // cast to int
            int hourly1 = Convert.ToInt32(Console.ReadLine());
            // hours per week
            Console.WriteLine("Hours worked per week: ");
            // cast to int
            int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());
            // calculate salary
            int salary1 = (hourly1 * hoursPerWeek1) * 52;

            // Person 2
            // hourly rate
            Console.WriteLine("Person 2\nHourly Rate: ");
            // cast to int
            int hourly2 = Convert.ToInt32(Console.ReadLine());
            // hours per week
            Console.WriteLine("Hours worked per week: ");
            // cast to int
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
            // calculate salary
            int salary2 = (hourly2 * hoursPerWeek2) * 52;

            // print person 1 salary
            Console.WriteLine("Annual salary of Person 1: \n" + salary1);
            // print person 2 salary
            Console.WriteLine("Annual salary of Person 2: \n" + salary2);

            // comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salary1 > salary2);

            Console.Read();
        }
    }
}
