using System;
using System.Threading;

namespace _021_Monitor
{
    class Program
    {
        // Объект для блокировки.
        static object block = new object();

        // Счетчик потоков.
        static int counter;

        // Генератор случайных чисел
        static Random random = new Random();
        static void Main()
        {
            Thread reporter = new Thread(Report) { IsBackground = true };
            reporter.Start();

            Thread[] threads = new Thread[150];

            for (uint i = 0; i < 150; ++i)
            {
                threads[i] = new Thread(Function);
                threads[i].Start();
            }

            // Задержка
            Console.ReadKey();
        }

        private static void Function()
        {
            lock (block)
            {
                counter++;
            }

            int time = random.Next(1000, 12000);
            Thread.Sleep(time);

            lock (block)
            {
                counter--;
            }
        }
        private static void Report()
        {
            while (true)
            {
                int count;

                lock (block)
                {
                    count = counter;
                }

                Console.WriteLine("{0} потоков активно", count);
                Thread.Sleep(100);
            }
        }
    }
}
