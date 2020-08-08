using System;
using System.Threading;

/// <summary>
/// Потоки
/// Используя класс Thread, мы можем выделить в приложении несколько потоков, 
/// которые будут выполняться одновременно.
/// </summary>
namespace _014_Threads
{
    class Program
    {
        static void Main()
        {
            // Для создания нового потока используется делегат ThreadStart, 
            // который получает в качестве параметра имя метода, который будет 
            // выполнятся в отделном потоке.
            ThreadStart writeSecond = new ThreadStart(WriteSecond);

            // Используя класс Thread, мы можем выделить в приложении несколько потоков, 
            // которые будут выполняться одновременно.
            Thread thread = new Thread(writeSecond);

            // Для запуска потока, вызывается метод Start. 
            thread.Start();

            while (true)
            {
                Console.WriteLine("Primary");
            }

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 10) + "Secondary");
            }
        }
    }
}
