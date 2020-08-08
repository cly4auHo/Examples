//#define DEBUG
#define VC_V7xxx
using System;

/// <summary>
/// Директивы препроцессора.
/// Директива #define определяет последовательность символов, называемую идентификатором. 
/// Присутствие или отсутствие идентификатора может быть определено с помощью директивы 
/// #if или #elif и поэтому используется для управления процессом компиляции.
/// </summary>
namespace _027_PreprocessorDirectives
{
    class Program
    {
        static void Main()
        {
#if (DEBUG && !VC_V7)
            Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V7)
            Console.WriteLine("VC_V7 is defined");
#elif (DEBUG && VC_V7)
            Console.WriteLine("DEBUG and VC_V7 are defined");
#else
            Console.WriteLine("DEBUG and VC_V7 are not defined");
#endif

            // Задержка.
            Console.ReadKey();
        }
    }
}
