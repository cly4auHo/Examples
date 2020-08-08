using System;

/// <summary>
/// С помощью директив #region и #endregion определяется область, 
/// которая разворачивается или сворачивается при структурировании исходного 
/// кода в интегрированной среде разработки Visual Studio. 
/// </summary>
namespace _025_PreprocessorDirectives
{
    class Program
    {
        static void Main()
        {
            #region MyRegion - имя Региона, для удобства

            Console.WriteLine("Hello...");

            #endregion

            // Задержка.
            Console.ReadKey();
        }
    }
}
