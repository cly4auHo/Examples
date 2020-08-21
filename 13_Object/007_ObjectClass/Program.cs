using System;

/// <summary>
/// Базовый класс Object.
/// </summary>
namespace _007_ObjectClass
{
    class Program
    {
        static void Main()
        {
            Object obj1 = new Object();
            Object obj2 = new Object();

            // Определяет, считаются ли равными указанные экземпляры объектов.
            Console.WriteLine(Equals(obj1, obj2));

            obj1 = obj2;

            Console.WriteLine(Equals(obj1, obj2));

            // Задержка.
            Console.ReadKey();
        }
    }
}
