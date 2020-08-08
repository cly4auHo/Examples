using System;
using System.Threading;

namespace _009_CriticalSection
{
    class Program
    {
        static object locker = new object();
        static void Main()
        {
            // Создание єкземпляра делегата ThreadStart, сообщаем
            // делегат с методом WriteSecond
            ThreadStart writeSecond = new ThreadStart(WriteSecond);

            // Создание вторичного потока.
            Thread thread = new Thread(writeSecond);

            // Запуск вторичного потока. 
            thread.Start();

            for (int i = 0; i < 20; i++)
            {
                lock (locker)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Primary");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void WriteSecond()
        {
            for (int i = 0; i < 20; i++)
            {
                lock (locker)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string(' ', 10) + "Secondary");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(100);
                }
            }
        }
    }
}
