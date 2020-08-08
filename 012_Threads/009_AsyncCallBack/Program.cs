using System;
using System.Threading;

/// <summary>
/// Асинхронные делегаты
/// Делегат AsyncCallback 
/// </summary>
namespace _009_AsyncCallBack
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            Func<int, int, int> func = new Func<int, int, int>(Sum);

            func.BeginInvoke(1, 2, CallBack, func);

            Console.WriteLine("Первичный поток завершил работу.");

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для выполнения в отдельном потоке.
        /// </summary>
        static int Sum(int a, int b)
        {
            Console.WriteLine(Thread.CurrentThread.IsBackground);
            //Thread.CurrentThread.IsBackground = false;

            Console.WriteLine("Вторичный поток: Id {0}", 
                Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(3000);
            return a + b;
        }

        /// <summary>
        /// Метод обработки завершения асинхронной операции.
        /// </summary>
        static void CallBack(IAsyncResult asyncResult)
        {
            // Получение экземпляра делегата, на котором была вызвана асинхронная операция.
            Func<int, int, int> caller = (asyncResult.AsyncState as Func<int, int, int>);

            // Получение результатов асинхронной операции.
            int sum = caller.EndInvoke(asyncResult);

            Console.WriteLine("a + b = {0}", sum);
        }
    }
}
