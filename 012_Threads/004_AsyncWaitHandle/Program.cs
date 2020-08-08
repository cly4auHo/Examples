using System;
using System.Threading;

/// <summary>
/// Асинхронные делегаты
/// Возвращаемое значение
/// </summary>
namespace _004_AsyncWaitHandle
{
    class Program
    {
        static void Main()
        {
            Func<int, int, int> myDelegate = new Func<int, int, int>(Sum);

            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

            Console.WriteLine("Асинхронный метод запущен. Метод Main продолжает работать.");
            Console.WriteLine("Метод Main ожидает завершения асинхронной задачи.");

            // Тип объект синхронизации 
            // ManualResetEvent
            Console.WriteLine(asyncResult.AsyncWaitHandle.GetType());
            
            // Приостановка первичного потока
            // WaitOne - блокирует текущий поток, пока текущий System.Threading.WaitHandle 
            // не получит сигнал.
            asyncResult.AsyncWaitHandle.WaitOne(); 

            Console.WriteLine("Асинхронный метод завершен. Метод Main продолжает работать.");

            // Получение результата асинхронной операции.
            int result = myDelegate.EndInvoke(asyncResult);
            Console.WriteLine("Результат = " + result);

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для выполнения в отдельном потоке.
        /// </summary>
        static int Sum(int a, int b)
        {
            Thread.Sleep(3000);
            return a + b;
        }
    }
}
