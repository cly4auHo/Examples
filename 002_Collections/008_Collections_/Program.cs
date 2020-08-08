using System;
using System.Collections.Generic;

/// <summary>
/// Коллекция Dictionary<T, V>
/// Перебор элементов коллекции Dictionary<T, V>
/// </summary>
namespace _008_Collections_
{
    class Program
    {
        static void Main()
        {
            // Создание коллекции Dictionary с именем countries
            Dictionary<int, string> countries = new Dictionary<int, string>();

            // Add - Добавляет указанные ключ и значение в словарь.
            // key - Ключ добавляемого элемента.
            // value - Добавляемое значение элемента
            countries.Add(1, "Russia");
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");

            // 1.Перебор можно осуществить с помощью цикла for
            for (int i = 1; i < countries.Count; i++)
            {
                Console.WriteLine(i + " - " + countries[i]);
            }

            Console.WriteLine(new string('-', 10));

            // 2.Перебор можно осуществить с помощью цикла foreach
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
