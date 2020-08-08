using System;
using System.Threading;

/// <summary>
/// Потоки
/// Приоритеты потоков 
/// </summary>
namespace _017_Priority
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Press any key...");
            Console.ReadKey();

            Console.WriteLine("Приоритет первичного потока по умолчанию: {0}",
                Thread.CurrentThread.Priority);

            PriorityTest priorityTest = new PriorityTest();

            //Создаем массив потоков
            Thread[] threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(priorityTest.Method);
            }

            // Установка 1- вому потоку приоритета Lowest
            threads[0].Priority = ThreadPriority.Lowest;

            // Установка c 2- го по 5- й поток приоритета Highest
            for (int i = 1; i < 5; i++)
            {
                threads[i].Priority = ThreadPriority.Highest;
            }

            // Запуск 1-го потока с низким приоритетом
            threads[0].Start();

            // Приостановка запуска потоков с высоким приоритетом
            Thread.Sleep(2000);

            // Запуск 4-их потоков с высоким приоритетом
            for (int i = 1; i < 5; i++)
            {
                threads[i].Start();
            }

            // Задержка
            Console.ReadKey();
        }
    }

    class PriorityTest
    {
        public void Method()
        {
            Console.WriteLine("Поток {0,3} с приоритетом {1,11} начал работу",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.Priority);

            Func<double, double> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;

            for (int i = 0; i < 20; ++i)
                //Console.WriteLine("{0:D2}-е число: {1}", i + 1, fib(i));
                fib(i);

            Console.WriteLine("Поток {0,3} с приоритетом {1,11} завершился.",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.Priority);
        }
    }
}
