using System;
using System.Threading;

/// <summary>
/// Потоки. Анонимные методы.
/// </summary>
namespace _005_Threads
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            // Делегат ThreadStart
            Thread thread = new Thread(delegate () 
                {
                    Console.WriteLine("1. counter = {0}", ++counter); 
                });

            // Запуск вторичного потока. 
            thread.Start();

            Thread.Sleep(100);
            Console.WriteLine("2. counter = {0}", ++counter);

            //Делегат ParameterizedThreadStart
            thread = new Thread((object argument) => 
                {
                    Console.WriteLine("3. counter = {0}", (int)argument); 
                });

            // Запуск вторичного потока. 
            thread.Start(counter);

            // Задержка.
            Console.ReadKey();
        }
    }
}
