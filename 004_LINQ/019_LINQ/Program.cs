using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// let - представляет новый локальный идентификатор, на который можно ссылаться в остальной части запроса.
/// Его можно представить, как локальную переменную видимую только внутри выражения запроса.
/// </summary>
namespace _019_LINQ
{
    class Program
    {
        static void Main()
        {
            // Построить коллекцию сотрудников.
            var employees = new List<Employee>
            {
                new Employee {LastName = "Ivanov", FirstName = "Ivan"},
                new Employee {LastName = "Andreev", FirstName = "Andrew"},
                new Employee {LastName = "Petrov", FirstName = "Petr"}
            };

            // Построить запрос.
            var query = from emp in employees
                        let fullName = emp.FirstName + " " + emp.LastName // let - новый локальный идентификатор.
                        let fullName1 = emp.FirstName + " " + emp.LastName // let - новый локальный идентификатор.
                        orderby (emp.FirstName + " " + emp.LastName) descending
                        select fullName;

            foreach (var person in query)
            {
                Console.WriteLine(person);
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс Сотрудника
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
    }
}
