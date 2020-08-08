﻿using System;
using System.Threading;

/// <summary>
/// Асинхронные делегаты
/// </summary>
namespace _005_Async_Polling
{
    class Program
    {
        static void Main()
        {
            Func<int, int, int> myDelegate = new Func<int, int, int>(Sum);

            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

            Console.WriteLine("Асинхронный метод запущен. Метод Main продолжает работать.");

            // Выполнение цикла до тех пор, пока работает асинхронная операция.
            while (!asyncResult.IsCompleted)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }

            // Получение результата асинхронной операции.
            int result = myDelegate.EndInvoke(asyncResult);

            Console.WriteLine("\nРезультат = " + result);

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
