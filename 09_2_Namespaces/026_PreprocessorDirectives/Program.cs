using System;

/// <summary>
/// Директивы препроцессора.
/// </summary>
namespace _026_PreprocessorDirectives
{
    class Program
    {
        static void Main()
        {
#if DEBUG
            Console.WriteLine("Debug version");
#endif

            //TODO: Посмотрите в Task List;
            // HACK: Посмотрите в Task List

            Console.WriteLine("Release version");

            // Задержка.
            Console.ReadKey();
        }
    }
}
