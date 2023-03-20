using System;
using System.Collections.Generic;
using System.Linq;

namespace _013_LINQ
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee { FirstName = "Ivan", LastName = "Ivanov" },
                new Employee { FirstName = "Petr", LastName = "Petrov" },
                new Employee { FirstName = "Alex", LastName = "Alexeev" },
            };

            var query = from emp in employees
                        let fullname = emp.FirstName + " " + emp.LastName // let - локальный идентификатор
                        orderby fullname descending
                        select fullname;

            foreach(var item in query)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
