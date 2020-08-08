using System;
using System.Collections;

/// <summary>
/// Hashtable
/// Перебор элементов коллекции
/// </summary>
namespace _024_Collections_Hashtable
{
    class Program
    {
        static void Main()
        {
            // Hashtable - Представляет коллекцию пар «ключ-значение», которые упорядочены по хэш-коду ключа.
            Hashtable hashtable = new Hashtable();

            //Добавление элементов в коллекцию, с помощью индексатора
            hashtable["sbishop@contoso.com"] = "Bishop, Scott";
            hashtable["chess@contoso.com"] = "Hell, Christian";
            hashtable["djump@contoso.com"] = "Jump, Dan";

            foreach (object name in hashtable)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(new string('-', 20));

            // DictionaryEntry - Инициализирует новый экземпляр класса DictionaryEntry типа
            // с указанным ключом и значением.
            // key: - Объект, определенный в каждой паре "ключ-значение".
            // value: - Определение, связанное с key.
            foreach (DictionaryEntry name in hashtable)
            {
                //name.Key - ключ
                //name.Value - значение, которое лежит по данному ключу в коллекции
                Console.WriteLine(name.Key + " - " + name.Value);
            }

            Console.WriteLine(new string('-', 20));

            foreach (object name in hashtable.Values)
            {
                Console.WriteLine(name);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
