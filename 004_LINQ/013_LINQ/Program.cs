using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Соединение в LINQ используется для объединения двух разнотипных наборов в один. 
/// Для соединения используется оператор join
/// </summary>
namespace _013_LINQ
{
    class Program
    {
        static void Main()
        {
            // Построить коллекцию сотрудников.
            var employees = new List<EmployeeID>
            {
                new EmployeeID {Id = "111", Name = "Ivan Ivanov"},
                new EmployeeID {Id = "222", Name = "Andrey Andreev"},
                new EmployeeID {Id = "333", Name = "Petr Petrov"},
                new EmployeeID {Id = "444", Name = "Alex Alexeev"}
            };

            // Построить коллекцию национальностей.
            var empNationalities = new List<EmployeeNationality>
            {
                new EmployeeNationality {Id = "111", Nationality = "Russian"},
                new EmployeeNationality {Id = "222", Nationality = "Ukrainian"},
                new EmployeeNationality {Id = "333", Nationality = "American"},
                new EmployeeNationality {Id = "533", Nationality = "American"}
            };

            // Построить запрос.
            // Получение списка имен всех сотрудников вместе с их национальностями, при этом отсортировав список по убыванию.
            var query = from emp in employees
                        join n in empNationalities
                        on emp.Id equals n.Id
                        orderby n.Nationality descending // ascending - по возрастанию | descending - по убыванию.
                        select new
                        {
                            Id = n.Id,
                            Name = emp.Name,
                            Nationality = n.Nationality
                        };

            foreach (var person in query)
            {
                Console.WriteLine("{0}, {1}, \t{2}", person.Id, person.Name, person.Nationality);
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс Сотрудник
    /// </summary>
    public class EmployeeID
    {
        /// <summary>
        /// Табельный номер 
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// Класс национальность сотрудника 
    /// </summary>
    public class EmployeeNationality
    {
        /// <summary>
        /// Табельный номер 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string Nationality { get; set; }
    }
}
