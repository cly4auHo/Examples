using System;
using System.Collections;
using System.Collections.Specialized;

/// <summary>
/// OrderedDictionary - Размещение элементов соответствует порядку их добавления в коллекцию, 
///  что позволяет автоматически сохранять элементы в хронологическом порядке. 
/// </summary>
namespace _030_Collections_OrderedDictionary
{
    class Program
    {
        static void Main()
        {
            // Представляет коллекцию пар "ключ-значение", доступ к которым можно получить по
            // ключу и индексу.
            OrderedDictionary orderedDictionary = new OrderedDictionary
                                  {
                                      {"sbishop@contoso.com", "Bishop, Scott"},
                                      {"chess@contoso.com", "Hell, Christian"},
                                      {"djump@contoso.com", "Jump, Dan"}
                                  };
            
            // Перебор элементов коллекции
            foreach (DictionaryEntry entry in orderedDictionary)
            {
                Console.WriteLine(entry.Value);
            }

            // Задержка
            Console.ReadKey();
        }
    }
}
