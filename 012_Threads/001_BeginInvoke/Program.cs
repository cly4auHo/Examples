using System;
using System.Threading;

/// <summary>
/// Асинхронные делегаты
/// Наиболее простым способом для создания потока является определение 
/// делегата и его вызов асинхронным образом. Делегаты могут исполнять 
/// роль безопасных для типов ссылок на методы. Помимо этого класс 
/// Delegate поддерживает и возможность асинхронного вызова этих методов. 
/// Для решения поставленной задачи он создает "за кулисами" отдельный поток.
/// </summary>
namespace _001_BeginInvoke
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            Action myDelegate = new Action(Method);

            // Invoke() - синхронный вызов. 
            //myDelegate.Invoke();

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            // Асинхронный вызов метода - Method 
            //(с использованием пула потоков).
            myDelegate.BeginInvoke(null, null); 

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(100);
                Console.Write("1 ");
            }

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод для выполнения в отдельном потоке.
        /// </summary>
        static void Method()
        {
            Console.WriteLine("Вторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(100);
                Console.Write("2 ");
            }
        }
    }
}
