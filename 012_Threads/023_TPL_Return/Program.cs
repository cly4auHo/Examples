using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Возвращение значения из задачи.
/// </summary>
namespace _023_TPL_Return
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            Context context;
            context.a = 2;
            context.b = 3;

            Task<int> task;

            // 1 вариант
            /*task = new Task<int>(Sum, context);
            task.Start();*/

            // 2 вариант
            /*
            TaskFactory<int> factory = new TaskFactory<int>();
            // StartNew - Создает и запускает задачу.
            task = factory.StartNew(Sum, context);
            */

            // 3 вариант
            
            // StartNew - Создает и запускает задачу.
            task = Task<int>.Factory.StartNew(Sum, context);
            

            Console.WriteLine("Результат выполнения задачи Sum = " + task.Result);

            Console.WriteLine("Основной поток завершен.");

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод который будет возвращать результат.
        /// </summary>
        static int Sum(object arg)
        {
            int a = ((Context)arg).a;
            int b = ((Context)arg).b;

            Thread.Sleep(2000);

            return a + b;
        }

        /// <summary>
        /// Структура Context
        /// </summary>
        struct Context
        {
            public int a;
            public int b;
        }
    }
}
