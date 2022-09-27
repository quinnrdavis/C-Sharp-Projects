using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare list of employees
            List<Employee> employees = new List<Employee>();

            // instantiate each employee and add it to the list
            Employee e1 = new Employee() { Id = 0, firstName = "Quinn", lastName = "Davis" };
            employees.Add(e1);
            Employee e2 = new Employee() { Id = 1, firstName = "Bob", lastName = "Smith" };
            employees.Add(e2);
            Employee e3 = new Employee() { Id = 2, firstName = "Dave", lastName = "Jones" };
            employees.Add(e3);
            Employee e4 = new Employee() { Id = 3, firstName = "Sally", lastName = "Johnson" };
            employees.Add(e4);
            Employee e5 = new Employee() { Id = 4, firstName = "Joe", lastName = "Reed" };
            employees.Add(e5);
            Employee e6 = new Employee() { Id = 5, firstName = "Anne", lastName = "Sharp" };
            employees.Add(e6);
            Employee e7 = new Employee() { Id = 6, firstName = "Roger", lastName = "Burvis" };
            employees.Add(e7);
            Employee e8 = new Employee() { Id = 7, firstName = "Joe", lastName = "Panson" };
            employees.Add(e8);
            Employee e9 = new Employee() { Id = 8, firstName = "Herbert", lastName = "Spradley" };
            employees.Add(e9);
            Employee e10 = new Employee() { Id = 9, firstName = "Joe", lastName = "Gronald" };
            employees.Add(e10);

            // declare list of joes
            List<Employee> joes = new List<Employee>();

            // loop over each employee in employees and if they are a joe add them to joes
            foreach (Employee emp in employees)
            {
                if (emp.firstName == "Joe")
                {
                    joes.Add(emp);
                }
            }

            // verifying in console that joes contains each joe
            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.firstName);
            }

            // another list of joes created with a lambda expression
            List<Employee> joes2 = employees.FindAll(x => x.firstName == "Joe");

            // verifying in console that joes2 contains each joe
            foreach (Employee joe in joes2)
            {
                Console.WriteLine(joe.firstName);
            }

            // new list that contains employees with id greater than 5 populated via lambda expression
            List<Employee> overFive = employees.FindAll(x => x.Id > 5);

            // verifying in console that overFive contains each employee with id > 5
            foreach (Employee emp in overFive)
            {
                Console.WriteLine(emp.Id);
            }

            Console.Read();
        }
    }
}
