using System;
using System.Threading;

/// <summary>
/// Потоки
/// ThreadStatic - Предоставляет поля типа, относящиеся к потоку (Общая переменная)
/// </summary>
namespace _012_Thread_Join
{
    class Program
    {
        /// <summary>
        /// Общая переменная счетчик 
        /// </summary>
        //[ThreadStatic] //TODO Снять комментарий 
        public static int counter;
        static void Main()
        {
            ThreadStart method = new ThreadStart(Method);
            Thread thread = new Thread(method);
            thread.Start();
            thread.Join();

            Console.WriteLine("Первичный поток завершил работу.");

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Рекурсивный запуск потоков
       /// </summary>
        public static void Method()
        {
            if (counter < 100)
            {
                counter++; // Увеличение счетчика вызваных методов
                Console.WriteLine(counter + " - СТАРТ --- " + Thread.CurrentThread.GetHashCode());

                Thread thread = new Thread(Method);
                thread.Start();
                thread.Join(); // Закомментировать
            }

            Console.WriteLine("Поток {0} завершился.", Thread.CurrentThread.GetHashCode());
        }
    }
}
