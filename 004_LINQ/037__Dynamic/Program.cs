using System;

/// <summary>
/// Динамические типы данных.
/// Динамические типы в делегатах.
/// </summary>
namespace _037__Dynamic
{
    class Program
    {
        delegate dynamic MyDelegate(dynamic argument);
        static void Main()
        {
            dynamic myDelegate = new MyDelegate(Method);

            dynamic @string = myDelegate("Hello world!");

            Console.WriteLine(@string);

            // Задержка.
            Console.ReadKey();
        }
        static dynamic Method(dynamic argument)
        {
            return argument;
        }
    }
}
