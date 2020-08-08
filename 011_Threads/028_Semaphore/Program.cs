using System;
using System.Threading;

/// <summary>
/// Потоки
/// Класс Semaphore - используется для управления доступом к пулу ресурсов. 
/// Потоки занимают слот семафора, вызывая метод WaitOne() 
/// и освобождают занятый слот вызовом метода Release().
/// </summary>
namespace _028_Semaphore
{
    class Program
    {
        static Semaphore pool;
        static void Main()
        {
            /*
               Аргументы:
               1. Задаем количество слотов для использования в данный момент 
                  (не более максимального клоличества задаваемого вторым аргументом).
               2. Задаем максимальное количество слотов для данного семафора.
               3. Имя семафора в операционной системе.
            */
            pool = new Semaphore(5, 4, "MySemafore");

            pool.Release(2); // Сброс семафора

            for (int i = 1; i <= 8; i++)
            {
                new Thread(Function).Start(i);
            }

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        ///  Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void Function(object number)
        {
            pool.WaitOne();

            Console.WriteLine("Поток {0} занял слот семафора.", number);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0} -----> освободил слот.", number);

            pool.Release();
        }

    }
}
