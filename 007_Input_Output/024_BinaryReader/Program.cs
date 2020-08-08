using System;
using System.IO;

/// <summary>
/// Использование BinaryReader.
/// </summary>
namespace _024_BinaryReader
{
    class Program
    {
        static void Main()
        {
            // Открываем файл.
            FileStream file = File.Open(@"D:\test.txt", FileMode.Open);

            // Сообщаем поток с файлом.
            BinaryReader reader = new BinaryReader(file);

            // Читаем из файла разные данные.
            long number = reader.ReadInt64();
            byte[] bytes = reader.ReadBytes(4);
            string s = reader.ReadString();

            // Удаляем поток.
            reader.Close();

            // Выводим на экран то, что удалось прочитать.
            Console.WriteLine(number);
            foreach (byte b in bytes)
            {
                Console.Write("[{0}]", b);
            }

            Console.WriteLine();
            Console.WriteLine(s);

            // Задержка.
            Console.ReadKey();
        }
    }
}
