using System;

/// <summary>
///  Динамические типы данных.
/// </summary>
namespace _034__Dynamic
{
    class Program
    {
        static void Main()
        {
            for (dynamic i = 0; i < 10; i++)
            {
                Console.WriteLine(i.GetType().Name);
                Console.WriteLine(new string('-', 10));
                Console.WriteLine("Hello world!");
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
