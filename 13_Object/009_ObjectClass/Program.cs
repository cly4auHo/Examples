using System;

/// <summary>
///  Базовый класс Object.
/// </summary>
namespace _009_ObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj = new Object();

            Type type = obj.GetType();

            Console.WriteLine(type.ToString());

            // Задержка.
            Console.ReadKey();
        }
    }
}
