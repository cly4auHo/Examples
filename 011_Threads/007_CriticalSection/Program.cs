using System;
using System.Threading;

/// <summary>
/// lock - блокирует блок кода так, что в каждый отдельный момент времени, этот блок кода
/// сможет использовать только один поток. Все остальные потоки ждут пока текущий поток, 
/// закончит работу.
/// </summary>
namespace _007_CriticalSection
{
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            for (int i = 0; i < 3; i++)
            {
                new Thread(instance.Method).Start();
            }

            Thread.Sleep(500);

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        object block = new object();

        /// <summary>
        /// Метод Method
        /// </summary>
        public void Method()
        {
            //Has потока
            int hash = Thread.CurrentThread.GetHashCode();

            // Оператор lock определяет блок кода, внутри которого весь код блокируется 
            // и становится недоступным для других потоков до завершения работы текущего потока. 
            lock (block) // Закомментировать lock.
            {
                for (int counter = 0; counter < 10; counter++)
                {
                    Console.WriteLine("Поток # {0}: шаг {1}", hash, counter);
                    Thread.Sleep(200);
                }

                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
