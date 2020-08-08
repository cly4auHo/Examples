using System;
using System.Collections.Generic;
using System.Linq;

namespace _006_LINQ
{
    class Program
    {
        static void Main()
        {
            var employees = new List<Person>
            { 
                new Person
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 94000,
                    StartDate = DateTime.Parse("1/4/1992")
                },
                new Person
                {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Salary = 123000,
                    StartDate = DateTime.Parse("12/3/1985")
                },
                new Person
                {
                    FirstName = "Andrey",
                    LastName = "Andreev",
                    Salary = 1000000,
                    StartDate = DateTime.Parse("1/12/2005")
                }
            };

            var query = from emp in employees
                        where emp.Salary > 100000
                        select new { emp.LastName, emp.FirstName, emp.Salary };
            
            //Использование вызовов статических методов.
            //var query = Enumerable.Select(Enumerable.Where( employees, emp => emp.Salary > 100000),emp => new { emp.LastName, emp.FirstName, emp.Salary });
            
            //var query =
            //    employees.Where(emp => emp.Salary > 100000)
            //        .Select(emp => new {LastName = emp.LastName, FirstName = emp.FirstName, Salary = emp.Salary});
            
            foreach (var item in query)
            {
                Console.WriteLine("FirstName = {0} | LastName = {1} | Salary = {2}", item.FirstName, item.LastName, item.Salary);
            }
            
            Console.ReadKey();
            
        }
    }
}
