using System;

/// <summary>
/// Базовый класс Object.
/// </summary>
namespace _002_ObjectClass
{
    class MyClass: Object
    {
        /// <summary>
        /// Переопредение метода то ToString()
        /// </summary>
        public override string ToString()
        {
            return "Hello world!";
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            Console.WriteLine(instance.ToString());

            // Задержка.
            Console.ReadKey();
        }
    }
}
