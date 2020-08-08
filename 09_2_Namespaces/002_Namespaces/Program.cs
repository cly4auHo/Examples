using System;

/// <summary>
/// Пространства имен.
/// Директива using - импортирует пространство имен, 
/// избавляя от необходимости полной квалификации имен стереотипов.
/// </summary>
namespace _002_Namespaces
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello world");

            System.Console.WriteLine("Hello world");

            //Задержка
            System.Console.ReadKey();
        }
    }
}
