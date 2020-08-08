using System;
using System.IO;

/// <summary>
/// Чтение из файла
/// Stream 
/// </summary>
namespace _010_BeginRead
{
    class Program
    {
        static void Main()
        {
            Stream stream = new FileStream("file.txt", FileMode.Open, FileAccess.Read);

            byte[] array = new byte[stream.Length];

            // Синхронный вызов метода, который считает все байты файла 
            // file.txt в массив.
            //stream.Read(array, 0, array.Length);

            // Асинхронный вызов метода чтения байтов файла.
            IAsyncResult asyncResult = stream.BeginRead(array, 0, array.Length, null, null);

            Console.WriteLine("Чтение файла ...");

            // Ожидание завершения чтения файла.
            stream.EndRead(asyncResult);

            foreach (byte item in array)
            {
                Console.Write(item + " ");
            }

            stream.Close();

            // Задержка
            Console.ReadKey();
        }
    }
}
