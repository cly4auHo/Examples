using System;
using System.Threading;

/// <summary>
/// SemaphoreSlim - легковесный семафор
/// [не использует средства операционной системы].
/// </summary>
namespace _029_SemaphoreSlim
{
    class Program
    {
        static SemaphoreSlim pool;
        static void Main()
        {
            /*
               Аргументы:
               1. Задаем количество слотов для использования в данный момент 
                  (не более максимального клоличества задаваемого вторым аргументом).
               2. Задаем максимальное количество слотов для данного семафора.
            */
            pool = new SemaphoreSlim(2, 4);

            for (int i = 1; i <= 8; i++)
            {
                new Thread(Function).Start(i);
            }

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void Function(object number)
        {
            pool.Wait();

            Console.WriteLine("Поток {0} занял слот семафора.", number);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0} -----> освободил слот.", number);

            pool.Release();
        }
    }
}
