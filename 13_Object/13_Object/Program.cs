using System;

/// <summary>
/// Базовый класс Object.
/// </summary>
namespace _13_Object
{
    class MyClassA : Object
    {
    }

    class MyClassB : object
    {
    }

    class Program
    {
        static void Main()
        {
            Object instanceA = new MyClassA();
            object instanceB = new MyClassB();

            // Задержка.
            Console.ReadKey();
        }
    }
}
