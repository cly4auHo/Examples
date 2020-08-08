using System;
using System.Collections;

/// <summary>
///  Итератор по сути представляет блок кода, 
///  который использует оператор yield для перебора набора значений.
///  yield return: определяет возвращаемый элемент
/// </summary>
namespace _012_Collections_yield
{
    class Program
    {
        static void Main()
        {
            foreach (string element in UserCollection.Power())
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(new string('-', 12));

            //-----------------------------------------------------------------------------------------------
            // Так работает foreach.

            /*IEnumerable enumerable = UserCollection.Power();

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext()) // Перемещаем курсор на 1 шаг вперед.
            {
                String element = enumerator.Current as String;

                Console.WriteLine(element);
            }*/

            // Задержка. 
            Console.ReadKey();
        }
    }

    #region UserCollection -  Пользовательская коллекция
    /// <summary>
    /// Пользовательская коллекция
    /// </summary>
    class UserCollection
    {
        /// <summary>
        /// yield return: определяет возвращаемый элемент
        /// </summary>
        public static IEnumerable Power()
        {
            yield return "Hello world!";
        }
    }
    #endregion
}
