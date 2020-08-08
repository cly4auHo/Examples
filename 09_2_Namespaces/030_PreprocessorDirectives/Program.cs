using System;

/// <summary>
/// Директивы препроцессора.
/// </summary>
namespace _030_PreprocessorDirectives
{
    class Program
    {
        static void Main()
        {
            // #error - позволяет создавать ошибку первого уровня из определенного места в коде.

            #error Ошибка определенная пользователем. // Снять комментарий.
            Console.WriteLine(1);


            // Задержка.
            Console.ReadKey();
        }
    }
}
