using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _028_TPL_TaskScheduler
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Main ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            List<Task> tasks = new List<Task>();
            TaskScheduler scheduler = new DelayTaskScheduler();
            TaskFactory factory = new TaskFactory(scheduler);
            tasks.Add(factory.StartNew(MyTask1));
            tasks.Add(factory.StartNew(MyTask2));

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine("\nВсе задачи завершены.");
        }

        /// <summary>
        /// Метод 1 который будет выполнен асинхронно.
        /// </summary>
        static void MyTask1()
        {
            Console.WriteLine("MyTask1 ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write("+ ");
            }
        }

        /// <summary>
        /// Метод 1 который будет выполнен асинхронно.
        /// </summary>
        static void MyTask2()
        {
            Console.WriteLine("MyTask2 ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write("- ");
            }
        }

        /// <summary>
        /// Планировщик задержеки 
        /// </summary>
        class DelayTaskScheduler : TaskScheduler
        {
            Queue<Task> queue = new Queue<Task>();

            /// <summary>
            /// Вызывается 1-ым.
            /// </summary>
            protected override void QueueTask(Task task) 
            {
                Console.WriteLine("QueueTask");
                queue.Enqueue(task);

                WaitCallback callback = (object state) => base.TryExecuteTask(queue.Dequeue());

                // Асинхронный вызов задач.
                ThreadPool.QueueUserWorkItem(callback, null); 
            }

            /// <summary>
            /// Вызывается 2-ым.
            /// </summary>
            /// <param name="task"></param>
            /// <param name="taskWasPreviouslyQueued"></param>
            /// <returns></returns>
            protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
            {
                Console.WriteLine("TryExecuteTaskInline");
                return false; // return true; - Будет исключение.
            }

            protected override IEnumerable<Task> GetScheduledTasks()
            {
                return queue;
            }
        }

    }
}
