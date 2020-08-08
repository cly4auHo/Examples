using System;
using System.Collections;

/// <summary>
///  Итератор по сути представляет блок кода, 
///  который использует оператор yield для перебора набора значений.
///  yield break: указывает, что последовательность больше не имеет элементов
/// </summary>
namespace _014_Collections_yield
{
    class Program
    {
        static void Main()
        {
            foreach (string element in UserCollection.Power())
            {
                Console.Write(element);
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
            yield return "vdc";

            if (true)
            {
                // yield break: указывает, что последовательность 
                // больше не имеет элементов
                yield break;
            }

        }
    }
}
