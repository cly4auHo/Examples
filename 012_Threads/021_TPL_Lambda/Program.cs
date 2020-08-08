using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Использование лямбда-выражения в качестве задачи.
/// </summary>
namespace _021_TPL_Lambda
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            // Использование лямбда-оператора для определения задачи.
            Task task = new Task(new Action(() =>
            {
                {for (int i = 0; i < 80; i++)
                {
                    Thread.Sleep(20);
                    Console.Write(".");
                }}
            }));

            task.Start();

            // Ожидание завершения задачи.
            task.Wait();

            // Освобождение задачи. 
            task.Dispose();

            Console.WriteLine("Основной поток завершен.");

            // Задержка
            Console.ReadKey();
        }
    }
}
