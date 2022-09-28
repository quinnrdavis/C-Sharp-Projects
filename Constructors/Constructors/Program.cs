using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // a const variable
            const string str = "This is a const";
            Console.WriteLine(str);

            // a variable declared with var
            var str2 = "This is a var";
            Console.WriteLine(str2);

            // instantiate class with constructor chain
            ConstructorChains cc = new ConstructorChains();
            // print Id property that was assigned by the chained constructor
            Console.WriteLine(cc.Id);

            Console.Read();
        }
    }
}
