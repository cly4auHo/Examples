using System;
using System.Collections;

/// <summary>
///  Итератор по сути представляет блок кода, 
///  который использует оператор yield для перебора набора значений.
/// </summary>
namespace _013_Collections_yield
{
    class Program
    {
        static void Main()
        {
            Numbers numbers = new Numbers();

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            // Задержка. 
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс Numbers
    /// </summary>
    class Numbers
    {
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 6; i++)
            {
                yield return i * i;
            }
        }
    }
}
