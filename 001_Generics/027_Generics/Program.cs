using System;

/// <summary>
/// System.Nullable<T>
/// var && dynamic 
/// </summary>
namespace _027_Generics
{
    class Program
    {
        static void Main()
        {
            // Неявно типизированная локальная переменная не может быть - Nullable.
            // var? c = null;

            // Неявно типизированная локальная переменная не может быть - Nullable.
            // var? c = null;

            // dynamic может быть -Nullable.
            dynamic @dynamic = null;

            Console.WriteLine(@"<{0}>", @dynamic);

            // Задержка.
            Console.ReadKey();
        }
    }
}
