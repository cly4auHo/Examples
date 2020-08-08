using System;
using System.Collections;
using System.Collections.Specialized;

/// <summary>
/// ListDictionary - Подходит для хранения небольшого количества элементов, 
/// поскольку организована по принципу обычного массива.
/// </summary>
namespace _028_Collections_ListDictionary
{
    class Program
    {
        static void Main()
        {
            // Реализует IDictionary с помощью однонаправленного списка. Рекомендуется для коллекций,
            // которые обычно содержат менее 10 элементов.
            ListDictionary emailLookup = new ListDictionary();

            // Использование индексатора дя добавление элемента
            emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup["chess@contoso.com"] = "Hell, Christian";
            emailLookup["djump@contoso.com"] = "Jump, Dan";

            // Перебор элементов коллекции
            foreach (DictionaryEntry entry in emailLookup)
            {
                Console.WriteLine(entry.Value);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
