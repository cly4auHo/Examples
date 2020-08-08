using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace _040__Async_and_Await
{
    class Program
    {
        static void Main()
        {
            // Асинхронный метод
            ReadWriteAsync();

            Console.WriteLine("Некоторая работа");

            // Задержка
            Console.ReadLine();
        }

        /// <summary>
        /// Асинхронный метод
        /// </summary>
        static async void ReadWriteAsync()
        {
            string s = "Hello world! One step at a time";

            // hello.txt - файл, который будет записываться и считываться
            using (StreamWriter writer = new StreamWriter("hello.txt", false))
            {
                // асинхронная запись в файл
                await writer.WriteLineAsync(s);
            }
            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                // асинхронное чтение из файла
                string result = await reader.ReadToEndAsync();
                Console.WriteLine(result);
            }
        }
    }
}
