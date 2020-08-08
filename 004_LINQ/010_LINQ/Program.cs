using System;
using System.Collections.Generic;

/// <summary>
/// Собственная реализация where и select.
/// </summary>
namespace _010_LINQ
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var query = from x in numbers
                        where x % 2 == 0
                        select x * 2;

            foreach (var item in query)
                Console.WriteLine(item);

            // Задержка.
            Console.ReadKey();
        }
    }

    public static class MySet
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            Console.WriteLine("Вызвана собственная реализация Where.");
            return System.Linq.Enumerable.Where(source, predicate);
        }

        public static IEnumerable<R> Select<T, R>(this IEnumerable<T> source, Func<T, R> selector)
        {
            Console.WriteLine("Вызвана собственная реализация Select.");
            return System.Linq.Enumerable.Select(source, selector);
        }
    }
}
