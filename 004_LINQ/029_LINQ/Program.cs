using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Reverse -  Изменяет порядок элементов в последовательности.
/// </summary>
namespace _029_LINQ
{
    class Program
    {
        static void Main()
        {
            var values = new[] { "A", "B", "C", "C" };

            IEnumerable<string> strings = values.Reverse();

            foreach (string item in values.Reverse().Reverse().Reverse())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
