using System;

/// <summary>
///  dynamic - Это ключевое слово позволяет опустить проверку типов во время компиляции. 
///  Кроме того, объекты, объявленные как dynamic, могут в течение работы программы менять свой тип
/// </summary>
namespace _031__Dynamic
{
    class Program
    {
        static void Main()
        {
            dynamic variable = 1;

            Console.WriteLine(variable);

            variable = "Hello world!";

            Console.WriteLine(variable);

            variable = DateTime.Now;

            Console.WriteLine(variable);

            // Задержка.
            Console.ReadKey();
        }
    }
}
