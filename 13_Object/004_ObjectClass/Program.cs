using System;

/// <summary>
/// Базовый класс Object.
/// </summary>
namespace _004_ObjectClass
{
    class Program
    {
        static void Main()
        {
            Object obj1 = new Object();
            Object obj2 = new Object();

            // Определяет, равен ли заданный объект текущему объекту.
            Console.WriteLine(obj1.Equals(obj2));

            // Раскоментировать
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());

            obj1 = obj2;

            Console.WriteLine(obj1.Equals(obj2));

            // Раскоментировать
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());

            // Задержка.
            Console.ReadKey();
        }
    }
}
