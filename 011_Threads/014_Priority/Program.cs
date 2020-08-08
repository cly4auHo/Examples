using System;
using System.Threading;

/// <summary>
/// Потоки
/// Свойство IsBackground указывает, является ли поток фоновым
/// </summary>
namespace _014_Priority
{
    class Program
    {
        static void Main()
        {
            ThreadStart procedure = new ThreadStart(Procedure);

            Thread thread = new Thread(procedure);

            // IsBackground - устанавливает поток как фоновый. 
            // Не ждем завершения вторичного потока в данном случае.
            // По умолчанию - thread.IsBackground = false; 
            //thread.IsBackground = true; // Закомментировать.

            thread.Start();

            Thread.Sleep(500);

            Console.WriteLine("\nЗавершение главного потока.");
        }

        /// <summary>
        /// Метод выполняющийся в отдельном потоке
        /// </summary>
        static void Procedure()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(10);
                Console.Write(".");
            }
            Console.WriteLine("\nЗавершение вторичного потока.");
        }
    }
}
