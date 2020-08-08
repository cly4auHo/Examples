using System;
using System.Collections;

/// <summary>
/// Hashtable
/// </summary>
namespace _026_Collections_Hashtable
{
    class Program
    {
        static void Main()
        {
            // Hashtable - Представляет коллекцию пар «ключ-значение», которые упорядочены по хэш-коду ключа.
            Hashtable hashtable = new Hashtable();

            Person person1 = new Person("Herring");
            Person person2 = new Person("Herring");

            hashtable[person1] = "Hello";
            hashtable[person2] = "Hello2";
            
            // 2 объекта так как они имеют разные хеш-коды.
            Console.WriteLine(hashtable.Count);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Value);
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс Person (Человек)
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string name;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name"></param>
        public Person(string name)
        {
            this.name = name;
        }
    }
}
