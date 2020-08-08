using System;
using System.Threading;

/// <summary>
/// Потоки. Передача данных в поток.
/// Делегат ParameterizedThreadStart используется если надо передать параметры в поток.
/// При использовании ParameterizedThreadStart мы сталкиваемся с ограничением: мы можем 
/// запускать во втором потоке только такой метод, который в качестве единственного 
/// параметра принимает объект типа object.
/// </summary>
namespace _004_Threads
{
    class Program
    {
        static void Main()
        {
            // Создание єкземпляра делегата ParameterizedThreadStart, сообщаем
            // делегат с методом WriteSecond
            ParameterizedThreadStart writeSecond = new ParameterizedThreadStart(WriteSecond);

            // Создание вторичного потока.
            Thread thread = new Thread(writeSecond);

            // Запуск вторичного потока. 
            thread.Start("World");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
                Thread.Sleep(1000);
            }

            Thread.Sleep(500);

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, который планируется выполнять в отдельном потоке.
        /// </summary>
        static void WriteSecond(object argument)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string(' ', 10) +  argument);
                Thread.Sleep(1000);
            }
        }
    }
}
