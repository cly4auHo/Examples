using System;
using System.Threading;

/// <summary>
/// Асинхронные делегаты
/// Возвращаемое значение
/// </summary>
namespace _003_EndInvoke
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            Func<int, int, int> myDelegate = new Func<int, int, int>(Sum);

            // Первые 2 аргумента - аргументы метода Sum(1, 2).
            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

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
            Console.WriteLine("Вторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(2000);
            return a + b;
        }
    }
}
