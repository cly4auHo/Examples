using System;
using System.Threading;

/// <summary>
/// Асинхронные делегаты
/// Делегат AsyncCallback 
/// Если передается объект AsyncCallback, делегат автоматически вызовет 
/// указанный метод по завершении асинхронного вызова.
/// </summary>
namespace _006_Async_CallBack
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первичный поток: Id {0}", 
                Thread.CurrentThread.ManagedThreadId);

            Action action = new Action(Method);

            // Делегат, метод которого будет запущен по завершению асинхронной операции.
            AsyncCallback callback = new AsyncCallback(CallBack);

            // Аргументы: 
            // 1. Принимает метод обратного вызова, который должен сработать 
            // по завершению асинхронной операции.
            // 2. Дополнительный объект хранящий состояние, который будет доступен 
            // в методе обратного вызова.
            action.BeginInvoke(callback, null);

            Console.WriteLine("Первичный поток продолжает работать.");

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Callback метод для обработки завершения асинхронной операции.
        /// </summary>
        static void CallBack(IAsyncResult asyncResult)
        {
            Console.WriteLine("Callback метод. Thread Id {0}",
                Thread.CurrentThread.ManagedThreadId);
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
    }
}

