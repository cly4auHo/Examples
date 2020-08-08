using System;
using System.Threading;

/// <summary>
/// Потоки 
/// Приоритеты потоков.
/// Пример из MSDN.
/// </summary>
namespace _015_Priority
{
    class Program
    {
        static void Main()
        {
            PriorityTest priorityTest = new PriorityTest();
            ThreadStart startDelegate = priorityTest.ThreadMethod;

            //Создание 1-го потока (приоритет Lowest)
            Thread threadOne = new Thread(startDelegate);
            threadOne.Name = "ThreadOne";
            threadOne.Priority = ThreadPriority.Lowest;

            //Создание 2-го потока (приоритет Highest)
            Thread threadTwo = new Thread(startDelegate);
            threadTwo.Name = "ThreadTwo";
            threadTwo.Priority = ThreadPriority.Highest;

            //Запуск 2-х потоков
            threadOne.Start();
            threadTwo.Start();

            // Дать 10 секунд на выполнение потоков
            Thread.Sleep(1000);

            // Остановка работы всех потоков
            priorityTest.LoopSwitch = false;

            // Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс PriorityTest
    /// </summary>
    class PriorityTest
    {
        /// <summary>
        /// Флаг loopSwitch
        /// </summary>
        bool loopSwitch;

        /// <summary>
        /// Конструктор класса PriorityTest
        /// </summary>
        public PriorityTest()
        {
            loopSwitch = true;
        }

        /// <summary>
        /// Cвойство для изменения флага
        /// </summary>
        public bool LoopSwitch
        {
            set { loopSwitch = value; }
        }

        /// <summary>
        /// Метод ThreadMethod
        /// </summary>
        public void ThreadMethod()
        {
            long threadCount = 0;

            while (loopSwitch)
            {
                threadCount++;
            }

            Console.WriteLine("{0} with {1,11} priority has a count = {2,13}",
                Thread.CurrentThread.Name,
                Thread.CurrentThread.Priority.ToString(),
                threadCount.ToString("N0"));
        }
    }
}
