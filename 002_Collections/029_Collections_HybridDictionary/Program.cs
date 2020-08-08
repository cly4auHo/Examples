using System;
using System.Collections;
using System.Collections.Specialized;

/// <summary>
/// HybridDictionary - Рекомендуется к использованию в тех случаях, 
/// когда невозможно определить размер коллекции заранее.
/// </summary>
namespace _029_Collections_HybridDictionary
{
    class Program
    {
        static void Main()
        {
            // Реализует IDictionary с помощью System.Collections.Specialized.ListDictionary
            // при малых и последующее переключение коллекции System.Collections.Hashtable когда
            // коллекция увеличивается.
            HybridDictionary emailLookup = new HybridDictionary();

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
