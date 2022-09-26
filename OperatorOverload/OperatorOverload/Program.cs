using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate two employee objects with different names but the same id
            Employee e1 = new Employee() { Id = 1, firstName="Quinn" };
            Employee e2 = new Employee() { Id = 1, firstName="Bob" };

            // print results of overloaded comparisons
            Console.WriteLine(e1 == e2);
            Console.WriteLine(e1 != e2);

            Console.ReadLine();

        }
    }
}
