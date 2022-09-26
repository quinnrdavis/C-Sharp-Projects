using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate employee class
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            // call method
            employee.SayName();
        }
    }
}
