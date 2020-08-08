using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// В основе библиотеки TPL лежит концепция задач, каждая из которых описывает 
/// отдельную продолжительную операцию. В библиотеке классов .NET задача представлена 
/// специальным классом - классом Task, который находится в пространстве имен 
/// System.Threading.Tasks. Данный класс описывает отдельную задачу, которая 
/// запускается асинхронно в одном из потоков из пула потоков. 
/// Хотя ее также можно запускать синхронно в текущем потоке.
/// </summary>
namespace _013_TPL
{
    class Program
    {
        static void Main()
        {
            int threadId = Thread.CurrentThread.ManagedThreadId;

            Console.WriteLine("Main: запущен в потоке # {0}", threadId);

            Action action = new Action(MyTask);

            // Создание экземпляра задачи.
            Task task = new Task(action);

            // Запуск задачи на выполнение асинхронно.
            //task.Start();

            // Запуск задачи на выполнение синхронно.
            task.RunSynchronously();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(200);
            }

            Console.WriteLine("\nMain: завершен в потоке # {0}", threadId);

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод который будет выполнен асинхронно.
        /// </summary>
        static void MyTask()
        {
            int threadId = Thread.CurrentThread.ManagedThreadId;

            Console.WriteLine("\nMyTask: запущен в потоке # {0}", threadId);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write("+ ");
            }

            Console.WriteLine("\nMyTask: завершен в потоке # {0}", threadId);
        }
    }
}
