using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// group - является средством для разделения ввода запроса.
/// </summary>
namespace _021_LINQ
{
    class Program
    {
        static void Main()
        {
            // Построить коллекцию сотрудников с национальностями.
            var employees = new List<Employee>
            {
                new Employee {LastName = "Andreev", FirstName = "Andrew",  Nationality = "Ukrainian"},
                new Employee {LastName = "Ivanov",  FirstName = "Ivan",    Nationality = "Russian"},
                new Employee {LastName = "Andreev", FirstName = "Ivan",  Nationality = "Ukrainian"},
                new Employee {LastName = "Petrov",  FirstName = "Petr",    Nationality = "American"},
                new Employee {LastName = "Andreev", FirstName = "Sergey",  Nationality = "Ukrainian"},
                new Employee {LastName = "Petrov",  FirstName = "Slava",    Nationality = "American"}
            };

            // Построить запрос.
            var query = from emp in employees
                        group emp by new { Nationality = emp.Nationality, LastName = emp.LastName };

            foreach (var group in query)
            {
                Console.WriteLine(group.Key);

                foreach (var employee in group)
                {
                    Console.WriteLine("_____" + employee.FirstName);
                }
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс Сотрудник
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Национальность
        /// </summary>
        public string Nationality { get; set; }
    }
}
