using System;
using System.Collections;

/// <summary>
///  Итератор по сути представляет блок кода, 
///  который использует оператор yield для перебора набора значений.
///  Бесконейчный цикл
/// </summary>
namespace _015_Collections_yield
{
    class Program
    {
        static void Main()
        {
            foreach (string element in UserCollection.Power())
            {
                Console.WriteLine(element);
            }

            // Задержка. 
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Пользовательская коллекция
    /// </summary>
    class UserCollection
    {
        public static IEnumerable Power()
        {
            while (true)
                yield return "Hello world!";
        }
    }
}
