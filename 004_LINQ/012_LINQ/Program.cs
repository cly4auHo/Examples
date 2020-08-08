using System;
using System.Collections;
using System.Linq;

/// <summary>
/// Тип переменной диапазона.
/// </summary>
namespace _012_LINQ
{
    class Program
    {
        static void Main()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);
            //numbers.Add("test");

            // ЯВНОЕ указание типа Int32 переменной диапазона - n.  
            //(var - НЕВОЗМОЖНО использовать т.к. IEnumerable не параметризированный!)
            IEnumerable query = from int n in numbers
                                select n * 2;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
