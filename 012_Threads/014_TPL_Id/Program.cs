using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Класс Task
/// Свойства Id и CurrentId.
/// Id - Уникальный идентификатор определенного экземпляра Task.
/// CurrentId - Уникальный идентификатор выполняющейся задачи.
/// </summary>
namespace _014_TPL_Id
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Main: Task.CurrentId = {0}",  // Main - задача?
                Task.CurrentId == null ? "null" : Task.CurrentId.ToString());

            Task task1 = new Task(MyTask);
            Task task2 = new Task(MyTask);

            task1.Start();
            task2.Start();

            Console.WriteLine("Id задачи task1: " + task1.Id);
            Console.WriteLine("Id задачи task2: " + task2.Id);

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод который будет выполнен асинхронно.
        /// </summary>
        static void MyTask()
        {
            Console.WriteLine("MyTask: CurrentId {0} c ManagedThreadId {1} запущен.",
                Task.CurrentId, Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(2000);

            Console.WriteLine("MyTask: CurrentId " + Task.CurrentId + " завершен.");
        }

    }
}
