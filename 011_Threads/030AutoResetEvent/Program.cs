using System;
using System.Threading;

/// <summary>
/// AutoResetEvent - Уведомляет ожидающий поток о том, что произошло событие. 
/// </summary>
namespace _030AutoResetEvent
{
    class Program
    {
        // Аргумент:
        // false - установка в несигнальное состояние.
        static AutoResetEvent auto = new AutoResetEvent(false);
        static void Main()
        {
            Thread thread = new Thread(Function);
            thread.Start();
            Thread.Sleep(500); // Дадим время запуститься вторичному потоку.

            Console.WriteLine("Нажмите на любую клавишу для перевода AutoResetEvent в сигнальное состояние.\n");
            Console.ReadKey();
            auto.Set(); // Продолжение выполнения вторичного потока.

            Console.WriteLine("Нажмите на любую клавишу для перевода AutoResetEvent в сигнальное состояние.\n");
            Console.ReadKey();
            auto.Set(); // Продолжение выполнения вторичного потока.

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void Function()
        {
            Console.WriteLine("Красный свет");
            // Остановка выполнения вторичного потока.
            auto.WaitOne(); 

            Console.WriteLine("Желтый");
            // Остановка выполнения вторичного потока.
            auto.WaitOne(); 

            Console.WriteLine("Зеленый");

            // СПРАВКА:
            // После завершения метода WaitOne() - AutoResetEvent 
            // автоматически переходит в несигнальное состояние.
        }
    }
}
