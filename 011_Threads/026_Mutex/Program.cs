using System;
using System.Threading;

/// <summary>
/// Потоки 
/// Использование Mutex для синхронизации доступа к защищенным ресурсам.
/// Mutex - Примитив синхронизации, который также может использоваться  в межпроцессной 
/// синхронизации.
/// MutEx - Mutual Exclusion (Взаимное Исключение).
/// </summary>
namespace _026_Mutex
{
    class Program
    {
        // Отсутствует межпроцессная синхронизация. 
        //static Mutex mutex = new Mutex();
        // Присутствует межпроцессная синхронизация. 
        static Mutex mutex = new Mutex(false, "MyMutex"); 

        static void Main()
        {
            Thread[] threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(Function);
                threads[i].Name = i.ToString();
                Thread.Sleep(500); // Потоки из разных процессов успеют стать в очередь вперемешку.
                threads[i].Start();
            }

            // Зажержка
            Console.ReadKey();
        }

        /// <summary>
        ///  Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void Function()
        {
            // Блокирует текущий поток, пока текущий 
            // System.Threading.WaitHandle не получит сигнал.
            mutex.WaitOne();

            Console.WriteLine("Поток {0} зашел в защищенную область.", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0}  покинул защищенную область.\n", Thread.CurrentThread.Name);

            mutex.ReleaseMutex();
        }
    }
}
