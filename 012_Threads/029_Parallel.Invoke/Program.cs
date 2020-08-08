using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// ParallelOptions - Хранит параметры, настраивающие работу методов класса Parallel.
/// Класс Parallel также является частью TPL и предназначен для упрощения параллельного выполнения кода. 
/// Parallel имеет ряд методов, которые позволяют распараллелить задачу.
/// </summary>
namespace _029_Parallel.Invoke
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            ParallelOptions options = new ParallelOptions();

            // Выделить определенное количество процессорных ядер.
            // options.MaxDegreeOfParallelism = Environment.ProcessorCount > 2
            //                          ? Environment.ProcessorCount - 1 : 1;

            options.MaxDegreeOfParallelism = 2; // Попробовать 1 и 2

            Console.WriteLine("Количество логических ядер CPU:" + Environment.ProcessorCount);

            // Задержка
            Console.ReadKey();

            // Выполнить параллельно два метода.
            Parallel.Invoke(options, MyTask1, MyTask2);

            // Выполнить параллельно четыре метода.
            Parallel.Invoke(options, MyTask1, MyTask2, MyTask1, MyTask2);

            // ВНИМАНИЕ!
            // Выполнение метода Main() приостанавливается, 
            // пока не произойдет завершение задач.

            Console.WriteLine("Основной поток завершен.");

            // Задержка
            Console.ReadKey();
        }


        /// <summary>
        /// Метод 1, который будет выполнен асинхронно.
        /// </summary>
        static void MyTask1()
        {
            Console.WriteLine("MyTask1: запущен.");
           
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(10);
                Console.Write("+");
            }
            
            Console.WriteLine("MyTask1: завершен.");
        }


        /// <summary>
        /// Метод 2, который будет выполнен асинхронно.
        /// </summary>
        static void MyTask2()
        {
            Console.WriteLine("MyTask2: запущен.");
            
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(10);
                Console.Write("-");
            }
            
            Console.WriteLine("MyTask2: завершен.");
        }
    }
}
