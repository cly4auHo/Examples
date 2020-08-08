using System;
using System.Threading;

/// <summary>
/// Потоки
/// Создавать список потоков самостоятельно не понадобится. 
/// Для управления таким списком предусмотрен класс ThreadPool, 
/// который по мере необходимости уменьшает и увеличивает количество потоков 
/// в пуле до максимально допустимого. Значение максимально допустимого количества 
/// потоков в пуле может изменяться. В случае двуядерного ЦП оно по умолчанию составляет 1023 
/// рабочих потоков и 1000 потоков ввода-вывода.
/// </summary>
namespace _025_ThreadPool
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Начало работы программы");
            Report();

            // Запуск Task1 в потоке входящем в пул потоков
            ThreadPool.QueueUserWorkItem(new WaitCallback(Task1));
            Report();

            // Запуск Task2 в потоке входящем в пул потоков
            ThreadPool.QueueUserWorkItem(Task2);
            Report();

            Thread.Sleep(3000);
            Console.WriteLine("Завершение работы программы");
            Report();

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для выполнения в потоке 1
        /// </summary>
        static void Task1(Object state)
        {
            Thread.CurrentThread.Name = "1";
            Console.WriteLine("Запущен поток {0}\n", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0} завершил работу\n", Thread.CurrentThread.Name);
        }

        /// <summary>
        /// Метод для выполнения в потоке 2
        /// </summary>
        static void Task2(Object state)
        {
            Thread.CurrentThread.Name = "2";
            Console.WriteLine("Запущен поток {0}\n", Thread.CurrentThread.Name);
            Thread.Sleep(500);
            Console.WriteLine("Поток {0} завершил работу\n", Thread.CurrentThread.Name);
        }

        /// <summary>
        /// Метод для отображения в потоке
        /// </summary>
        static void Report()
        {
            Thread.Sleep(200);

            int availableWorkThreads;
            int availableIOThreads;
            int maxWorkThreads;
            int maxIOThreads;

            //Доступно рабочих потоков в пуле
            ThreadPool.GetAvailableThreads(out availableWorkThreads, out availableIOThreads);

            //Доступно потоков ввода-вывода в пуле
            ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIOThreads);

            Console.WriteLine("Доступно рабочих потоков в пуле     :{0} из {1}", availableWorkThreads, maxWorkThreads);
            Console.WriteLine("Доступно потоков ввода-вывода в пуле:{0} из {1}\n", availableIOThreads, maxIOThreads);
        }
    }
}
