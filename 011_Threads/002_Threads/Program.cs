using System;
using System.Threading;

/// <summary>
///  Потоки
///  CLR назначает каждому потоку свой стек и методы имеют свои собственные локальные переменные.
/// </summary>
namespace _002_Threads
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
            WriteSecond();

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Статический метод, который планируется выполнять одновременно 
        /// в главном (первичном) и во вторичном потоках.
        /// </summary>
        static void WriteSecond()
        {
            // Отдельный экземпляр переменной counter создается в стеке каждого потока, 
            // поэтому для каждого потока выводятся, свои значения counter - 0,1,2.
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("Thread Id {0}, counter = {1}", 
                    Thread.CurrentThread.GetHashCode(), counter);
                counter++;
            }
        }
    }
}
