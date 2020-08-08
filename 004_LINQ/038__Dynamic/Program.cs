using System;

/// <summary>
/// Динамические типы данных. 
/// Динамические типы в параметризированных делегатах
/// </summary>
namespace _038__Dynamic
{
    class Program
    {
        delegate R MyDelegate<T, R>(T argument);
        static void Main()
        {
            dynamic myDelegate = new MyDelegate<dynamic, dynamic>(Method);

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
