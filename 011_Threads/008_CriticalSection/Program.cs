using System;
using System.Threading;

/// <summary>
/// lock - это сокращенное использование System.Threading.Monitor.
/// Monitor.Enter(this) - блокирует блок кода так, что его может использовать только текущий поток. 
/// Все остальные потоки ждут пока текущий поток, закончит работу и вызовет Monitor.Exit(this).
/// </summary>
namespace _008_CriticalSection
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 40);

            MyClass instance = new MyClass();

            for (int i = 0; i < 3; i++)
            {
                new Thread(instance.Method).Start();
            }

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

            /// Monitor.Enter(this) - блокирует блок кода так, что его может использовать только 
            /// текущий поток. Все остальные потоки ждут пока текущий поток, закончит работу 
            /// и вызовет Monitor.Exit(this).
            Monitor.Enter(block); // Закомментировать.
            
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("Поток # {0}: шаг {1}", hash, counter);
                Thread.Sleep(100);
            }
            
            Console.WriteLine(new string('-', 20));

            Monitor.Exit(block);  // Закомментировать.
        }
    }
}
