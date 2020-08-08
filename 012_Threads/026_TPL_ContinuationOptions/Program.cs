using System;
using System.Threading.Tasks;

/// <summary>
/// Пример выполнять через (CTRL+F5).
/// TaskContinuationOptions - Задает поведение для задачи
/// </summary>
namespace _026_TPL_ContinuationOptions
{
    class Program
    {
        static void Main()
        {
            Task<int> task = new Task<int>(MyTask);

            Action<Task<int>> continuation;

            continuation = t => Console.WriteLine("Result : " + task.Result);

            // Создает продолжение, выполняемое в соответствии с условием, заданным в continuationOptions.
            task.ContinueWith(continuation, TaskContinuationOptions.OnlyOnRanToCompletion);

            continuation = t => Console.WriteLine("Inner Exception : " + task.Exception.InnerException.Message);

            // TaskContinuationOptions.OnlyOnFaulted - Указывает, что задача продолжения должна планироваться, 
            // только если предшествующая ей задача создала необработанное исключение
            task.ContinueWith(continuation, TaskContinuationOptions.OnlyOnFaulted);

            // Запускает задачу планируя ее выполнение в текущем планировщике 
            task.Start();

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод который будет выполнен асинхронно.
        /// </summary>
        static int MyTask()
        {
            byte result = 255;

            // Убрать комментарий.
            checked
            {
                result += 1;
            }

            return result;
        }
    }
}
