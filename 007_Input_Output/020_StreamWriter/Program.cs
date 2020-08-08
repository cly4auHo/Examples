using System;
using System.IO;

/// <summary>
/// Запись в файл.
/// </summary>
namespace _020_StreamWriter
{
    class Program
    {
        static void Main()
        {

            // Создание файла.
            FileStream file = File.Create(@"D:\test.txt");
            StreamWriter writer;
            
            // 1.
            writer = new StreamWriter(file);
            writer.WriteLine("Hello");
            writer.Close();
            //	file.Close();

            // 2.
            writer = File.CreateText(@"D:\test1.txt");
            writer.WriteLine("Hello");
            writer.Close();

            // 3.
            File.WriteAllText(@"D:\test1.txt", "Hello");

            // 4.
            //file = null;
            file = File.Open(@"D:\test1.txt", FileMode.Open, FileAccess.Write, FileShare.Write);
            file.Close();

            // 5.
            file = File.OpenWrite(@"D:\test1.txt");
            file.Close();

            // 6. Будет исключение, так как файл занят!
            file = File.Open(@"D:\test1.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            // file.Close();

            // Streams - необходимо закрывать!!!

            // Задержка
            Console.ReadKey();
        }
    }
}
