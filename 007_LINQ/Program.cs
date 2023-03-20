using System;
using System.Collections.Generic;
using System.Linq;

namespace _007_LINQ
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public DateTime StartDate { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 100000,
                    StartDate = DateTime.Parse("1/12/2020"),
                },
                new Employee
                {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Salary = 120000,
                    StartDate = DateTime.Parse("3/8/2018"),
                },
                new Employee
                {
                    FirstName = "Andrey",
                    LastName = "Andreev",
                    Salary = 150000,
                    StartDate = DateTime.Parse("5/3/2016"),
                },
            };

            // Выражение запроса.
            // query - переменная запроса.
            var query = employees
                        .Where(emp => emp.Salary > 100000)
                        .OrderBy(emp => emp.LastName)
                        .OrderBy(emp => emp.FirstName)
                        .Select(emp => new
                        {
                            LastName = emp.LastName,
                            FirstName = emp.FirstName,
                        });

            Console.WriteLine("Высокооплачиваемые сотрудники:");

            foreach (var item in query)
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);

            Console.ReadKey();
        }
    }
}
