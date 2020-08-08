using System;
using System.Collections;

/// <summary>
/// SortedList - коллекция, отсортированная по ключу,
/// класс сортирует элементы на основе значения ключа. 
/// </summary>
namespace _027_Collections_SortedList
{
    class Program
    {
        static void Main()
        {
            // Предоставляет коллекцию пар "ключ-значение", упорядоченных по ключам. Доступ
            // к парам можно получить по ключу и индексу.
            SortedList sortedList = new SortedList();

            // Использование индексатора дя добавление элемента
            sortedList["First"] = 1;
            sortedList["Second"] = "2nd";
            sortedList["Third"] = "3rd";
            sortedList["Fourth"] = "4th";
            sortedList["fourth"] = "4th";

            // Перебор элементов коллекции
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            Console.WriteLine(new string('-', 10));

            // Возвращает логическое значение true, если вызывающий список 
            // содержит объект key в качестве ключа; а иначе — логическое значение false
            bool contains = sortedList.ContainsKey("fourth");

            Console.WriteLine(contains);

            // Задержка.
            Console.ReadKey();
        }
    }
}
