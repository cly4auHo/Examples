using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Метод All.
/// Позволяет определить, соответствует ли коллекция определенному условию, 
/// и в зависимости от результата они возвращают true или false.
/// </summary>
namespace _030_LINQ
{
    class Program
    {
        static void Main()
        {
            List<User> users = new List<User>()
            {
                new User { Name = "Tom", Age = 23 },
                new User { Name = "Sam", Age = 43 },
                new User { Name = "Bill", Age = 35 }
            };

            // All - Определяет, является ли все элементы 
            // последовательности удовлетворяют условию.
            bool result1 = users.All(u => u.Age > 20); // true

            if (result1)
                Console.WriteLine("У всех пользователей возраст больше 20");
            else
                Console.WriteLine("Есть пользователи с возрастом меньше 20");

            bool result2 = users.All(u => u.Name.StartsWith("T")); //false
            if (result2)
                Console.WriteLine("У всех пользователей имя начинается с T");
            else
                Console.WriteLine("Не у всех пользователей имя начинается с T");

            Console.ReadKey();

        }
    }

    /// <summary>
    /// Пользователь
    /// </summary>
    class User
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }
    }
}
