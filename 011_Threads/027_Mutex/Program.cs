﻿using System;
using System.Threading;

/// <summary>
/// Потоки
/// Рекурсивное запирание.
/// </summary>
namespace _027_Mutex
{
    class Program
    {
        static Mutex mutex = new Mutex();
        static void Main()
        {
            Thread thread = new Thread(Method1);
            
            thread.Start();
            
            thread.Join();

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        ///  Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        public static void Method1()
        {
            // Блокирует текущий поток, пока текущий 
            // System.Threading.WaitHandle не получит сигнал.
            mutex.WaitOne();
            Console.WriteLine("Method1 Start " + Thread.CurrentThread.ManagedThreadId);
            Method2();
            mutex.ReleaseMutex();
            Console.WriteLine("Method1 Finish " + Thread.CurrentThread.ManagedThreadId);
        }

        /// <summary>
        ///  Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        public static void Method2()
        {
            // Блокирует текущий поток, пока текущий 
            // System.Threading.WaitHandle не получит сигнал.
            mutex.WaitOne();
            Console.WriteLine("Method2 Start " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000); // ...
            mutex.ReleaseMutex();
            Console.WriteLine("Method2 Finish " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}