using System;
using System.Threading;

/// <summary>
/// Асинхронные делегаты
/// Делегат AsyncCallback 
/// </summary>
namespace _007_Async_CallBack
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первичный поток: Id {0}", 
                Thread.CurrentThread.ManagedThreadId);

            Action action = new Action(Method);
            
            AsyncCallback callback = new AsyncCallback(CallBack);

            // Аргументы: 
            // 1. Принимает метод обратного вызова, который должен сработать 
            // по завершению асинхронной операции.
            // 2. Дополнительный объект хранящий состояние, который будет 
            // доступен в методе обратного вызова.
            action.BeginInvoke(callback, "Hello world!");

            Console.WriteLine("Первичный поток продолжает работать.");

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для выполнения в отдельном потоке.
        /// </summary>
        static void Method()
        {
            Console.WriteLine("\nВторичный поток: Id {0}", 
                Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }

            Console.WriteLine("Вторичный поток завершен.\n");
        }

        /// <summary>
        /// Callback метод для обработки завершения асинхронной операции.
        /// </summary>
        static void CallBack(IAsyncResult asyncResult)
        {
            Console.WriteLine("Callback метод. Thread Id {0}", 
                Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Информация связанная с асинхронной операцией - " 
                + asyncResult.AsyncState);
        }
    }
}
