using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Cast - Приводит элементы к указанному типу.
/// </summary>
namespace _025_LINQ
{
    class Program
    {
        static void Main()
        {
            string @string = "test";
            object @object = @string;

            object[] arrayValues = new object[] { "1", "2", "3", "AAA", @object };

            IEnumerable<string> arrayStrings = arrayValues.Cast<string>();

            Console.WriteLine(arrayStrings.First());

            foreach (var item in arrayStrings)
            {
                Console.WriteLine(item.GetType().Name);
            }

            //Аналог Cast<T> выглядит так:
            IEnumerable<string> arrayStringsSecond =
                from string x in arrayValues
                select x;

            foreach (var item in arrayStringsSecond)
            {
                Console.WriteLine(item);
            }

            //Проблема, например в arrayValues, есть не только елементы типа string.
            object[] arrayValuesWithInt = new object[] { "1", "2", "3", "AAA", 1 };

            // При попытке использовать два вышеупомянутых свойства будет ошибка!
            // Решение -использование  OfType<T>.
            // OfType<T>. – преобразует любое перечисление в строго типизированный вариант, 
            // используя слабое преобразование типов, т.е. пропуская элементы, не являющиеся типом T.

            IEnumerable<string> arrayStringsThird = arrayValuesWithInt.OfType<string>(); // последний элемент будет пропущен,

            Console.WriteLine(arrayStringsThird.Count());

            foreach (var item in arrayStringsThird)
            {
                Console.WriteLine(item);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
