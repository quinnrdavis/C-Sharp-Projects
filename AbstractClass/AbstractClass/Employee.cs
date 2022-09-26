using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // inherits from Person class
    public class Employee : Person
    {
        // override abstract method
        public override void SayName()
        {
            // print name to screen
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.ReadLine();
        }
    }
}
