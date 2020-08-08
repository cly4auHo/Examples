using System;
using System.Threading;

/// <summary>
/// Основные и фоновые потоки. 
/// Потоки переднего плана и фоновые потоки
/// По умолчанию свойство IsBackground равно false.
/// </summary>
namespace _006_Threads
{
    class Program
    {
        static void Main()
        {
            // Создание єкземпляра делегата ThreadStart, сообщаем
            // делегат с методом WriteSecond
            ThreadStart writeSecond = new ThreadStart(WriteSecond);

            // Создание вторичного потока.
            Thread thread = new Thread(writeSecond);

            // Запуск вторичного потока. 
            thread.Start();

            // Работа первичного потока.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Primary");
                Thread.Sleep(500);
            }

            // Завершить работу вторичного потока
            thread.IsBackground = true;
        }

        /// <summary>
        /// Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 15) + "Secondary");
                Thread.Sleep(500);
            }
        }
    }
}
