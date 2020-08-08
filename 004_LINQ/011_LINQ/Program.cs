using System;
using System.Linq;

/// <summary>
/// // Таблица умножения от 1 до 9.
/// </summary>
namespace _011_LINQ
{
    class Program
    {
        static void Main()
        {
            // Конструкция from похожа на оператор foreach.
            // Использование нескольких конструкций from, аналогично вложенным операторам foreach.

            var query = from x in new int[] { 1, 2, 3 } // Таблица умножения от 1 до 9.
                        // Range - Создает последовательность целых чисел в указанном диапазоне.
                        from y in Enumerable.Range(1, 10)
                        select new
                        {
                            X = x,
                            Y = y,
                            Product = x * y
                        };

            foreach (var item in query)
            {
                Console.WriteLine("{0} * {1} = {2}", item.X, item.Y, item.Product);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
