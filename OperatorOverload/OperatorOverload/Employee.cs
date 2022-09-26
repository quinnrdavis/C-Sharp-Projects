using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        // properties
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        // override ==, return true or false
        public static bool operator== (Employee e1, Employee e2)
        {
            return e1.Id == e2.Id;
        }

        // override !=, return true or false
        public static bool operator!= (Employee e1, Employee e2)
        {
            return e1.Id != e2.Id;
        }
    }
}
