using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

/// <summary>
/// 
/// </summary>
namespace _027_TPL_DelayTaskScheduler
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Main ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            // TaskScheduler - Представляет объект, обрабатывающий низкоуровневую постановку задач в очередь на потоки.
            TaskScheduler scheduler = new DelayTaskScheduler();
            TaskFactory factory = new TaskFactory(scheduler);
            // StartNew -  Создает и запускает задачу.
            Task task = factory.StartNew(MyTask);

            // TaskAwaiter - Предоставляет объект, который ожидает завершения асинхронной задачи.
            TaskAwaiter awaiter = task.GetAwaiter();

            while (!awaiter.IsCompleted)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            // Не вызывать так как в DelayTaskScheduler используется AutoResetEvent
            //task.Wait(); 

            Console.WriteLine("\nВсе задачи завершены.");
        }

        /// <summary>
        /// Метод который будет выполнен асинхронно.
        /// </summary>
        static void MyTask()
        {
            Console.WriteLine("MyTask ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write("+ ");
            }
        }
    }

    /// <summary>
    /// Планировщик задержки
    /// TaskScheduler - Представляет объект, обрабатывающий низкоуровневую постановку задач в очередь
    /// </summary>
    class DelayTaskScheduler : TaskScheduler
    {
        Queue<Task> queue = new Queue<Task>();
        
        AutoResetEvent auto = new AutoResetEvent(false);

        /// <summary>
        /// Вызывается автоматически фабрикой задач.
        /// </summary>
        /// <param name="task"></param>
        protected override void QueueTask(Task task) 
        {
            Console.WriteLine("QueueTask ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            // Enqueue - Добавляет объект в конец очереди
            queue.Enqueue(task);

            // WaitOrTimerCallback - Представляет метод, вызываемый после System.Threading.WaitHandle сигнала или истечении времени.
            WaitOrTimerCallback callback = 
                (object state, bool timedOut) => base.TryExecuteTask(queue.Dequeue());

            // Асинхронный вызов задачи с задержкой в 2 секунды.
            #region Аргументы
            /*     1. auto - от кого ждать сингнал.
                   2. callback - что выполнять.
                   3. null - 1-й аргумент Callback метода.
                   4. 2000 - интервал между вызовами Callback метода.
                   5. true - вызвать Callback метод один раз. false - вызывать Callback метод с интервалом.  */
            #endregion
            ThreadPool.RegisterWaitForSingleObject(auto, callback, null, 2000, true);
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            return false;
        }

        protected override IEnumerable<Task> GetScheduledTasks()
        {
            return queue;
        }
    }
}
