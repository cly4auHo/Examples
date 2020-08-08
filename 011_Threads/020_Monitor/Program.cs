using System;
using System.Threading;


namespace _020_Monitor
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

            Thread.Sleep(15000);
        }

        // Выполняется в отдельном потоке.
        private static void Function()
        {
            try
            {
                Monitor.Enter(block); // Начало блокировки. lock(block){
                counter++;
            }
            finally
            {
                Monitor.Exit(block);  // Конец блокировки. }
            }

            int wait = random.Next(1000, 12000);
            Thread.Sleep(wait);

            try
            {
                Monitor.Enter(block); // Начало блокировки.
                counter--;
            }
            finally
            {
                Monitor.Exit(block);  // Конец блокировки.
            }
        }

        /// <summary>
        /// Мониторинг количества запущеных потоков.
        /// </summary>
        static void Report()
        {
            while (true)
            {
                int count;

                try
                {
                    Monitor.Enter(block); // Начало блокировки.
                    count = counter;
                }
                finally
                {
                    Monitor.Exit(block);  // Конец блокировки.
                }

                Console.WriteLine("{0} потоков активно", count);
                Thread.Sleep(100);
            }
        }
    }
}
