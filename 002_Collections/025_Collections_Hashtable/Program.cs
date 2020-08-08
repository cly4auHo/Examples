using System;
using System.Collections;

/// <summary>
/// Hashtable
/// </summary>
namespace _025_Collections_Hashtable
{
    class Program
    {
        static void Main()
        {
            // Hashtable - Представляет коллекцию пар «ключ-значение», которые упорядочены по хэш-коду ключа.
            Hashtable hashtable = new Hashtable();

            hashtable["First"] = "1st";
            hashtable["First"] = "the first";

            Console.WriteLine(string.Format(@"Количество елементов в коллекции = {0}", hashtable.Count));

            foreach (var item in hashtable.Values)
            {
                Console.WriteLine(item);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
