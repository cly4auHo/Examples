using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// LINQ (Language-Integrated Query) - Интегрированный язык запрос
/// LINQ представляет простой и удобный язык запросов к источнику данных.
/// </summary>
namespace _008_LINQ
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

            // .(Использование вызовов расширяющих методов.)
            var query = // query - переменная запрса.
                        employeesList.Where(emp => emp.Salary > 100000)
                        .OrderBy(emp => emp.LastName)
                        .OrderBy(emp => emp.FirstName)
                        .Select(emp => new
                        {
                            LastName = emp.LastName,
                            FirstName = emp.FirstName
                        });


            Console.WriteLine("Высокооплачиваемые сотрудники:");

            foreach (var item in query)
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);

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
