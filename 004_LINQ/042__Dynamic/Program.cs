using System;

/// <summary>
/// Динамические типы данных.
/// Анонимные типы
/// </summary>
namespace _042__Dynamic
{
    class Program
    {
        static void Main()
        {
            dynamic instance = new { Name = "Alex", Age = 18 };

            Console.WriteLine(instance.Name);
            Console.WriteLine(instance.Age);

            // Задржка.
            Console.ReadKey();
        }
    }
}
