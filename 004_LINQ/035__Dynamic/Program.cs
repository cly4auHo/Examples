using System;

/// <summary>
/// Динамические типы данных. 
/// Динамические типы аргументов и возвращаемых значений методов.
/// </summary>
namespace _035__Dynamic
{
    class Program
    {
        static void Main()
        {
            string @string = Method("friend");

            Console.WriteLine(@string);

            // Задержка.
            Console.ReadKey();
        }
        static dynamic Method(dynamic argument)
        {
            return "Hello " + argument + "!";
        }
    }
}
