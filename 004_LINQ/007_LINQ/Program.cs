using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// LINQ (Language-Integrated Query) - Интегрированный язык запрос
/// LINQ представляет простой и удобный язык запросов к источнику данных.
/// </summary>
namespace _007_LINQ
{
    class Program
    {
        static void Main()
        {
            // База данных сотрудников.
            List<Employee> employeesList = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 94000,
                    StartDate = new DateTime(1992, 4, 1)
                },
                new Employee
                {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Salary = 123000,
                    StartDate = new DateTime(1985, 12, 3) 
                },
                new Employee
                {
                    FirstName = "Andrew",
                    LastName = "Andreev",
                    Salary = 1000000,
                    StartDate = new DateTime(1985, 10, 3)
                }
            };

            // Выражение запроса.
            var query =                                                // query - переменная запрса.
                        from employee in employeesList                 // from - объявляет переменную диапазона employee.
                        where employee.Salary > 100000                 // where - фильтр
                        orderby employee.LastName, employee.FirstName  // orderby - сортировка 
                        select new                                     // select - Опреация проекции.
                        {
                            LastName = employee.LastName,
                            FirstName = employee.FirstName,
                            test = employee.LastName.Substring(1, 1)
                        };

            Console.WriteLine("Высокооплачиваемые сотрудники:");

            foreach (var item in query)
            {
                Console.WriteLine("{0} {1} {2}", item.LastName, item.FirstName, item.test);
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс сотрудник 
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Имя 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Запрлата
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Дата начала работы 
        /// </summary>
        public DateTime StartDate { get; set; }
    }
}
