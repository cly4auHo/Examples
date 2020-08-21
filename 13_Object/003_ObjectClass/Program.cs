using System;

/// <summary>
/// Базовый класс Object.
/// </summary>
namespace _003_ObjectClass
{
    class MyClass
    {
        /// <summary>
        /// Переопределение HashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return 1234567890;
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            Console.WriteLine(instance.GetHashCode());

            // Задержка.
            Console.ReadKey();
        }
    }
}
