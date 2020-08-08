using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// orderby - используется для сортировки (последовательности) результата запроса.
/// </summary>
namespace _016_LINQ
{
    class Program
    {
        static void Main()
        {
            // Построить коллекцию сотрудников с национальностями.
            List<Employee> employees = new List<Employee>
            {
                new Employee {LastName = "Ivanov", FirstName = "Ivan", Nationality = "Russian"},
                new Employee {LastName = "Andreev", FirstName = "Andrew", Nationality = "Ukrainian"},
                new Employee {LastName = "Petrov", FirstName = "Petr", Nationality = "American"}
            };

            // Построить запрос.
            // Получение списка имен всех сотрудников вместе с их национальностями.
            var query = from emp in employees
                        orderby emp.Nationality ascending,
                        emp.LastName descending, // ascending - по возрастанию | descending - по убыванию.
                        emp.FirstName descending // по умолчанию - ascending.
                        select emp;

            foreach (var person in query)
                Console.WriteLine("{0}, \t{1}, \t{2}", person.LastName, person.FirstName, person.Nationality);

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс сотрудник Employee
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
