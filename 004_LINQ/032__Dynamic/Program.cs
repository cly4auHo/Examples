using System;

/// <summary>
/// Динамические типы данных. 
/// Статические поля
/// </summary>
namespace _032__Dynamic
{
    class Program
    {
        static dynamic field = 1;
        static void Main()
        {
            Console.WriteLine(field);

            field = "Hello world!";

            var field1 = "Hello world!";
            //field1 = 1;

            Console.WriteLine(field);

            field = DateTime.Now;

            Console.WriteLine(field);

            // Задержка.
            Console.ReadKey();
        }
    }
}
