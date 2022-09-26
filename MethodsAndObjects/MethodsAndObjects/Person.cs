using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Person
    {
        // first name and last name properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // print full name to screen
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.ReadLine();
        }
    }
}
