using System;
using System.Threading;

/// <summary>
/// Потоки. 
/// Метод Join - блокирует выполнение вызвавшего его потока до тех пор, 
/// пока не завершится поток, для которого был вызван данный метод
/// </summary>
namespace _010_Thread_Join
{
    class Program
    {
        /// <summary>
        /// Метод Main - выполняется в первичном потоке.
        /// </summary>
        static void Main()
        {
            //Отобразить HashCode текущего потока
            Console.WriteLine("ID Первичного потока: {0}", Thread.CurrentThread.GetHashCode());

            // Создание єкземпляра делегата ThreadStart, сообщаем
            // делегат с методом Function
            ThreadStart function = new ThreadStart(Function);

            // Создание нового потока
            Thread thread = new Thread(new ThreadStart(function));

            // Запуск вторичного потока. 
            thread.Start();

            // Ожидание первичным потоком, завершения работы вторичного потока.
           // thread.Join(); //TODO Снять или установить комментарий.

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write("-");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nПервичный поток завершился.");

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void Function()
        {
            //Отобразить HashCode текущего потока
            Console.WriteLine("ID Вторичного потока: {0}", Thread.CurrentThread.ManagedThreadId);
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Вторичный поток завершился.");
        }
    }
}
