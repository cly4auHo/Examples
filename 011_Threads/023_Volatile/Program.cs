using System;
using System.Threading;

/// <summary>
/// Альтернативные операциия VolatileWrite()
/// ключевому слову volatile.
/// </summary>
namespace _023_Volatile
{
    class Program
    {
        static int stop;
        static void Main()
        {
            Thread thread = new Thread(Function);
            thread.Start();

            Thread.Sleep(2000);

            Thread.VolatileWrite(ref stop, 1); // stop = 1;
            Console.WriteLine("Main: ожидание завершения вторичного потока.");
            thread.Join();
        }

        /// <summary>
        /// 
        /// </summary>
        private static void Function()
        {
            int x = 0;

            while (Thread.VolatileRead(ref stop) != 1)
            {
                Console.WriteLine(stop);
                x++;
            }

            Console.WriteLine("Function: поток остановлен при x = {0}.", x);
        }
    }
}
