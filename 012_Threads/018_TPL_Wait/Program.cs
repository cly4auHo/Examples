using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging; // Для использования AsyncResult

/// <summary>
/// Класс Task
/// IAsyncResult - Представляет состояние асинхронной операции.
/// </summary>
namespace _018_TPL_Wait
{
    class Program
    {
        static void Main()
        {
            Task task = new Task(MyTask);
            task.Start();

            Thread.Sleep(500);

            Console.WriteLine("\ntask.IsCompleted = " + task.IsCompleted);

            // Ожидание завершения асинхронной задачи.

            // Вариант 1:
            // Wait() Ожидает завершения выполнения задачи System.Threading.Tasks.Task.
            //task.Wait();

            // Вариант 2:
            // IsCompleted - Возвращает значение, которое показывает, завершилась ли задача
            
            /*while (!task.IsCompleted)
            { 
                Thread.Sleep(100); 
            }*/
            
            // Вариант 3: 
            // IAsyncResult - Представляет состояние асинхронной операции.
            IAsyncResult asynkResult = task as IAsyncResult;
            // ManualResetEvent - Уведомляет один или более ожидающих потоков о том, что произошло событие
            // AsyncWaitHandle - используется для ожидания завершения асинхронной операции.
            ManualResetEvent waitHandle = asynkResult.AsyncWaitHandle as ManualResetEvent;
            // WaitOne - Блокирует текущий поток до получения сигнала объектом System.Threading.WaitHandle.
            waitHandle.WaitOne();
            
            Console.WriteLine("\ntask.IsCompleted = " + task.IsCompleted);

            // Задержка
            // Console.ReadKey();
        }

        /// <summary>
        /// Метод который будет выполнен асинхронно.
        /// </summary>
        static void MyTask()
        {
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(25);
                Console.Write(".");
            }
        }
    }
}
