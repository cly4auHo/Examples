using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Класс Task
/// С завершением метода Main завершается недовыполненная задача MyTask
/// [завершается работа вторичного потока].
/// По умолчанию IsBackground == true
/// </summary>
namespace _016_TPL_IsBackground
{
    class Program
    {
        static void Main()
        {
            Task task = new Task(MyTask);
            task.Start();

            Thread.Sleep(500); // Время на запуск задачи.

            Console.WriteLine("\nMain завершен.");

            // Задержка
            //Console.ReadKey();
        }

        /// <summary>
        /// Метод который будет выполнен асинхронно.
        /// </summary>
        static void MyTask()
        {
           Thread.CurrentThread.IsBackground = false; // Снять комментарий.

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
        }
    }
}
