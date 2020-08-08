using System;
using System.Collections.Generic;

/// <summary>
/// Коллекция Dictionary<T, V>
/// Словарь хранит объекты, которые представляют пару ключ-значение. 
/// Каждый такой объект является объектом структуры KeyValuePair<TKey, TValue>. 
/// Благодаря свойствам Key и Value, которые есть у данной структуры, 
/// мы можем получить ключ и значение элемента в словаре.
/// </summary>
namespace _007_Collections_
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
            countries.Add(1, "Russia");
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");

            // получение элемента по ключу
            string country = countries[4];

            Console.WriteLine(country);

            // изменение объекта
            countries[4] = "Spain";

            // удаление по ключу
            countries.Remove(2);

            // Задержка.
            Console.ReadKey();
        }
    }
}
