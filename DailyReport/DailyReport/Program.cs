using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print greeting message
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");
            // Ask for name, store as string
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            // Ask for course, store as string
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            // Ask for page number, cast to int
            Console.WriteLine("What page number?");
            string strPageNum = Console.ReadLine();
            int pageNum = Convert.ToInt32(strPageNum);
            // Ask if help is needed, cast to bool
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string strHelpNeeded = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(strHelpNeeded);
            // Ask for positive experiences, store as string
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            // Ask for feedback, store as string
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            // Ask for hours studied, cast to int
            Console.WriteLine("How many hours did you study today?");
            string strHoursStudied = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(strHoursStudied);
            // Print response
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");


            Console.Read();
        }
    }
}
