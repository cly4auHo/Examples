using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Отмена задачи с использованием опроса. (Пример выполнять через CTRL+F5)
/// </summary>
namespace _026_TPL_Cancellation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            // Создать источник токенов отмены.
            CancellationTokenSource cancellation = new CancellationTokenSource();
            CancellationToken token = cancellation.Token;

            Task task = new Task(MyTask, token);
            task.Start();

            Thread.Sleep(2000);

            //cancellation.Cancel(); // Отмена выполняемой задачи.
            //task.Wait(); // Для обработки исключения обязательно вызвать Wait!
            
            try
            {
                cancellation.Cancel(); // Отмена выполняемой задачи.
                task.Wait(); // Для обработки исключения обязательно вызвать Wait!
            }
            catch (AggregateException e)
            {
                if (task.IsCanceled)
                    Console.WriteLine("\nЗадача отменена.\n");

                Console.WriteLine("Inner Exception : " + e.InnerException.GetType());
                Console.WriteLine("Message         : " + e.InnerException.Message);
                Console.WriteLine("Статус задачи   : " + task.Status);
            }

            Console.WriteLine("Основной поток завершен.");

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод который будет выполнен как задача.
        /// </summary>
        static void MyTask(object arg)
        {
            CancellationToken token = (CancellationToken)arg;

            // ThrowIfCancellationRequested - Создает исключение System.OperationCanceledException, 
            // если для данного токена есть запрос на отмену.
            // Если задача сразу после старта отменена - возбудить OperationCanceledException.
            // token.ThrowIfCancellationRequested();

            Console.WriteLine("MyTask запущен.");

            for (int i = 0; i < 80; i++)
            {
                if (token.IsCancellationRequested) // Задача отменена?
                {
                    Console.WriteLine("\nПолучен запрос на отмену задачи.");
                    token.ThrowIfCancellationRequested(); // Возбудить OperationCanceledException.
                }

                Thread.Sleep(100);
                Console.Write(".");
            }

            Console.WriteLine("\nMyTask завершен.");
        }
    }
}
