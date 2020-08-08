using System;
using System.Collections.Generic;

/// <summary>
/// SortedList<TKey, TValue> 
/// Если нужна коллекция, отсортированная по ключу, можно воспользоваться 
/// SortedList<TKey, TValue>. Этот класс сортирует элементы на основе значения 
/// ключа. Можно использовать не только любой тип значения, но также и любой тип ключа.
/// </summary>
namespace _033_Collections_SortedList_Generic
{
    class Program
    {
        static void Main()
        {
            // Представляет коллекцию пар «ключ-значение», упорядоченных по ключу на основе
            // реализации System.Collections.Generic.IComparer`1.
            SortedList<string, int> sortList = new SortedList<string, int>();

            // Использование индексатора дя добавление элемента
            sortList["Zero"] = 0;
            sortList["One"] = 1;
            sortList["Two"] = 2;
            sortList["Three"] = 3;

            // Перебор элементов коллекции
            foreach (var i in sortList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(new string('-', 10));

            // Перебор элементов коллекции
            foreach (KeyValuePair<string, int> i in sortList)
            {
                Console.WriteLine(i);
            }
            
            // Задержка.
            Console.ReadKey();
        }
    }
}
