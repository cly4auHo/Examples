using System;
using System.IO;

/// <summary>
/// Использование BinaryWriter.
/// </summary>
namespace _023_BinaryWriter
{
    class Program
    {
        static void Main()
        {
            // Создаем файл.
            FileStream file = File.Create(@"D:\test.txt");

            // Сообщаем с файлом наш BinaryWriter.
            BinaryWriter writer = new BinaryWriter(file);

            // Записываем в файл разные данные.
            long number = 100;
            var bytes = new byte[] { 10, 20, 50, 100 };
            string s = "hunger";

            writer.Write(number);
            writer.Write(bytes);
            writer.Write(s);

            // Удаляем поток.
            writer.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
