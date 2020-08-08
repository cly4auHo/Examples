using System;

/// <summary>
/// Динамические типы данных.
/// Нестатические поля
/// </summary>
namespace _033__Dynamic
{
    class Program
    {
        dynamic field = 1;
        dynamic field2 = "Hello";
        dynamic field3 = true;
        static void Main()
        {
            dynamic instance = new Program();

            Console.WriteLine(instance.field);

            instance.field = "Hello world!";

            Console.WriteLine(instance.field);

            instance.field = DateTime.Now;

            Console.WriteLine(instance.field);

            // Задержка.
            Console.ReadKey();
        }
    }
}
