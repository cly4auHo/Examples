using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Класс Task
/// WaitAll() - Ожидает завершения выполнения всех указанных объектов Task.
/// WaitAny() - Ожидает завершения выполнения любого из указанных объектов Task.
/// </summary>
namespace _019_TPL_WaitAll_Any
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            Task task1 = new Task(MyTask1);
            Task task2 = new Task(MyTask2);

            task1.Start();
            task2.Start();

            Console.WriteLine("Id задачи task1: " + task1.Id);
            Console.WriteLine("Id задачи task2: " + task2.Id);

            // WaitAll - Ожидает завершения выполнения всех указанных объектов Task.
            //Task.WaitAll(task1, task2);

            // WaitAny - Ожидает завершения выполнения любого из указанных объектов Task.
            Task.WaitAny(task1, task2);

            Console.WriteLine("Основной поток завершен.");

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Первый метод который будет выполнен асинхронно.
        /// </summary>
        static void MyTask1()
        {
            Console.WriteLine("MyTask: CurrentId " + Task.CurrentId + " запущен.");
            Thread.Sleep(2000);
            Console.WriteLine("MyTask: CurrentId " + Task.CurrentId + " завершен.");
        }

        /// <summary>
        /// Второй метод который будет выполнен асинхронно.
        /// </summary>
        static void MyTask2()
        {
            Console.WriteLine("MyTask: CurrentId " + Task.CurrentId + " запущен.");
            Thread.Sleep(3000);
            Console.WriteLine("MyTask: CurrentId " + Task.CurrentId + " завершен.");
        }

    }
}
