using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Approval
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for age
            Console.WriteLine("What is your age?");
            // cast input to int
            int age = Convert.ToInt32(Console.ReadLine());

            // ask if DUI
            Console.WriteLine("Have you ever had a DUI?");
            // cast input to bool
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            // ask how many speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            // cast input to int
            int tickets = Convert.ToInt32(Console.ReadLine());

            // print if qualified
            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && DUI == false && tickets <= 3);

            Console.Read();
        }
    }
}
