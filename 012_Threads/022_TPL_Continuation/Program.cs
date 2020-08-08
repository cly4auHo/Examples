using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Продолжение - автоматический запуск новой задачи, после завершения первой задачи.
/// </summary>
namespace _022_TPL_Continuation
{
    class Program
    {
        static void Main()
        {
            // Создание задачи.
            Action action = new Action(MyTask);
            
            Task task = new Task(action);

            // Создание продолжения задачи.
            Action<Task> continuation = new Action<Task>(ContinuationTask);

            // ContinueWith - Создает продолжение, которое выполняется асинхронно после завершения выполнения
            // целевой задачи 
            Task taskContinuation = task.ContinueWith(continuation);

            // Выполнение последовательности задач.
            task.Start();

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Метод который будет выполнен как задача.
        /// </summary>
        static void MyTask()
        {
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(200);
                Console.Write("+");
            }
        }

        /// <summary>
        /// Метод исполняемый как продолжение задачи.
        /// </summary>
        static void ContinuationTask(Task task)
        {
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(200);
                Console.Write("-");
            }
        }
    }
}
