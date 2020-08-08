using System;
using System.Threading;

/// <summary>
/// Потоки. 
/// Метод Join - блокирует выполнение вызвавшего его потока до тех пор, 
/// пока не завершится поток, для которого был вызван данный метод
/// </summary>
namespace _011_Thread_Join
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первичный поток # {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('1', 80, ConsoleColor.Green);

            // Создание єкземпляра делегата ThreadStart, сообщаем
            // делегат с методом Method2
            ThreadStart method2 = new ThreadStart(Method2);

            // Создание нового вторичного потока 
            Thread thread = new Thread(method2);

            // Запуск вторичного потока. 
            thread.Start();

            // Ожидание первичным потоком, завершения работы вторичного потока.
            thread.Join();

            WriteChar('1', 80, ConsoleColor.Green);

            Console.WriteLine("Первичный поток завершился.");

            // Задержка
            Console.ReadKey();

        }

        /// <summary>
        /// Метод выполняющийся во вторичном потоке (Запуск из первичного потока).
        /// </summary>
        public static void Method2()
        {
            Console.WriteLine("Вторичный поток # {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('2', 80, ConsoleColor.Blue);

            // Создание єкземпляра делегата ThreadStart, сообщаем
            // делегат с методом Method3
            ThreadStart method3 = new ThreadStart(Method3);

            // Создание третичного потока
            Thread thread = new Thread(method3);

            // Запуск третичного потока. 
            thread.Start();

            // Ожидание вторичным потоком, завершения работы третичным потока.
            thread.Join();

            WriteChar('2', 80, ConsoleColor.Blue);
            Console.WriteLine("Вторичный поток завершился.");
        }

        /// <summary>
        /// Метод выполняющийся в третичном потоке (Запуск из вторичного потока).
        /// </summary>
        public static void Method3()
        {
            Console.WriteLine("Третичный поток # {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('3', 80, ConsoleColor.Yellow);
            Console.WriteLine("Третичный поток завершился.");
        }

        /// <summary>
        /// Метод для вывода символов
        /// </summary>
        static void WriteChar(char chr, int count, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(20);
                Console.Write(chr);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
