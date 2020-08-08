using System;
using System.Threading;

/// <summary>
/// Потоки
/// Приоритеты потоков 
/// </summary>
namespace _016_Priority
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

            // Дать 10 секунд на выполнение потоков
            Thread.Sleep(1000);

            Console.WriteLine("Первичный поток проснулся и втиснулся между высокоприоритетных потоков");

            // Остановка работы всех потоков
            priorityTest.stop = true;

            // Задержка
            Console.ReadKey();
        }
    }

    class PriorityTest
    {
        public bool stop = false;

        public void Method()
        {
            Console.WriteLine("Поток {0,3} с приоритетом {1,11} начал работу",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.Priority);

            long count = 0;

            // Буфер предсказаний переходов может изменить работу исходного алгоритма.
            while (!stop)
            {
                count++;
            }

            Console.WriteLine("Поток {0,3} с приоритетом {1,11} завершился. Count = {2,13}",
                Thread.CurrentThread.ManagedThreadId,
                Thread.CurrentThread.Priority,
                count.ToString("N0"));
        }
    }
}
