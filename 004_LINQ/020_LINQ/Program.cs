using System;
using System.Linq;

/// <summary>
/// let - представляет новый локальный идентификатор, на который можно ссылаться в остальной части запроса.
/// Его можно представить, как локальную переменную видимую только внутри выражения запроса.
/// </summary>
namespace _020_LINQ
{
    class Program
    {
        static void Main()
        {
            // Построить запрос.
            var query = from x in Enumerable.Range(0, 10)
                        let innerRange = Enumerable.Range(0, 10)
                        from y in innerRange
                        select new { X = x, Y = y, Product = x * y };

            foreach (var item in query)
                Console.WriteLine("{0} * {1} = {2}", item.X, item.Y, item.Product);

            // Задержка.
            Console.ReadKey();
        }
    }
}
