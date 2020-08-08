using System;
using System.Threading;

/// <summary>
/// AutoResetEvent - Уведомляет ожидающий поток о том, что произошло событие. 
/// </summary>
namespace _031_AutoResetEvent
{
    class Program
    {
        // Аргумент:
        // false - установка в несигнальное состояние.
        static AutoResetEvent auto = new AutoResetEvent(false);
        static void Main()
        {
            new Thread(Function1).Start();
            new Thread(Function2).Start();

            Thread.Sleep(500);  // Дадим время запуститься вторичным потокам.

            Console.WriteLine("Нажмите на любую клавишу для перевода AutoResetEvent в сигнальное состояние.\n");
            Console.ReadKey();
            auto.Set(); // Посылает сигнал одному потоку.
            auto.Set(); // Посылает сигнал другому потоку.

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод 1, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void Function1()
        {
            Console.WriteLine("Поток 1 запущен и ожидает сигнала.");
            auto.WaitOne(); // Остановка выполнения вторичного потока 1.
            Console.WriteLine("Поток 1 завершается.");
        }

        /// <summary>
        /// Метод 2, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void Function2()
        {
            Console.WriteLine("Поток 2 запущен и ожидает сигнала.");
            auto.WaitOne(); // Остановка выполнения вторичного потока 2.
            Console.WriteLine("Поток 2 завершается.");
        }
    }
}
