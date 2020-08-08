using System;

/// <summary>
/// Директивы препроцессора.
/// </summary>
namespace _028_PreprocessorDirectives
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Строка #1.");
#line hidden // Скрывает строку от отладчика.
            Console.WriteLine("Скрытая строка."); // Установить BreakPoint.
#line default
            Console.WriteLine("Строка #2.");

            // Задержка.
            Console.ReadKey();
        }
    }
}
