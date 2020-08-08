using System;
using System.Linq;

/// <summary>
/// Any -  Определяет, содержит ли последовательность какие-либо элементы.
/// </summary>
namespace _027_LINQ
{
    class Program
    {
        static void Main()
        {
            var values = new[] { "1", "2", "3", "AAA", "ABB" };

            // Any - Определяет, содержит ли последовательность какие-либо элементы.
            if (values.Any())
            {
                foreach (string item in values)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine(new string('-', 10));

            // Для того, чтобы узнать, существуют ли элементы, удовлетворяющие 
            // какому-то условию, можно использовать метод Any<T>:

            bool hasAAA = values.Any(i => i.StartsWith("A")); // true

            if (hasAAA)
            {
                foreach (string item in values.Where(i => i.StartsWith("A")))
                {
                    Console.WriteLine(item);
                }
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
