using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// First<T> и Last<T> — извлечь первый и последний элемент перечисления
/// </summary>
namespace _026_LINQ
{
    class Program
    {
        static void Main()
        {
            var values = new[] { "1", "AAA", "2", "3", "ABB" };

            IEnumerable<string> strings = values.Where(i => i.StartsWith("A"));

            string firstElement = strings.First();
            string lastElement = strings.Last();

            Console.WriteLine(firstElement);
            Console.WriteLine(lastElement);

            // Задержка.
            Console.ReadKey();
        }
    }
}
