using System;
using System.Threading;

/// <summary>
/// Метод Abort уведомляет среду CLR о том, что надо прекратить поток, 
/// однако прекращение работы потока происходит не сразу, а только тогда, 
/// когда это становится возможно. 
/// </summary>
namespace _013_Thread_Abort
{
    class Program
    {
        static void Main()
        {
            Thread thread = new Thread(new ThreadStart(Procedure));
            thread.Start();

            // Дать время запуститься и поработать вторичному потоку.
            Thread.Sleep(2000);

            // Прервать выполнение потока (Генерируется исключение ThreadAbortException).
            thread.Abort(); // Закоментировать.

            // Ждать завершения работы вторичного потока
            thread.Join();

            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                Thread.Sleep(20);
                Console.Write("-");
            }
        }

        /// <summary>
        /// Метод выполняющийся в отдельном потоке
        /// </summary>
        static void Procedure()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                // Thread.Sleep(3000); // Ловушка для исключения ThreadAbortException.
                try
                {
                    // while (true) // Снять комментарий
                    {
                        Thread.Sleep(10);
                        Console.Write(".");
                    }
                }
                catch (ThreadAbortException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    // Попытка 'проглотить' исключение и продолжиться выполняться в данном цикле.
                    // То есть вернуться в цикл и продолжить выводить counter.
                    Console.WriteLine("\nThreadAbortException");

                    for (int i = 0; i < 50; i++)
                    {
                        //Thread.Sleep(20);
                        Console.Write(".");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;

                    // Если не вызывать Thread.ResetAbort() - 
                    // исключение повторно сгенерируется после выхода из catch{}
                    // Предотвращение повторной генерации ThreadAbortException!
                    //Thread.ResetAbort();
                }

                // Thread.Sleep(3000); // Ловушка для исключения ThreadAbortException.
            }
            Console.WriteLine("++++++++++++++++ НЕ ВЫПОЛНИТСЯ ++++++++++++++++");
        }
    }
}
