using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Удалить дубликаты из перечисления можно методом Distinct<T>.
/// </summary>
namespace _028_LINQ
{
    class Program
    {
        static void Main()
        {
            var values = new[] { "1", "1", "2", "2", "3", "3", "3" };

            foreach (string item in values.Distinct())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 10));

            IEnumerable<string> strings = values.Distinct(); // "1", "2", "3"

            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
