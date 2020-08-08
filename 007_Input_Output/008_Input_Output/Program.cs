using System;
using System.IO;

/// <summary>
/// MemoryStream представляет собой реализацию класса Stream, 
/// в которой массив байтов используется для ввода и вывода.
/// </summary>
namespace _008_Input_Output
{
    class Program
    {
        static void Main()
        {
            // Создаем объект класса MemoryStream.
            MemoryStream memoryStream = new MemoryStream();

            // Задаем требуемый объем памяти.
            memoryStream.Capacity = 256;

            // Этот массив соответствует: {'H','e','l','l','o',' ','W','o','r','l','d'}.
            byte[] bytes = new byte[] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 };

            // Записываем байты в поток.
            for (var i = 0; i < bytes.Length; i++)
            {
                memoryStream.WriteByte(bytes[i]);
            }

            // Переставляем внутренний указатель на начало.
            memoryStream.Position = 0;

            // Считывам байты из потока.
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write(" " + memoryStream.ReadByte());
            }

            Console.WriteLine(Environment.NewLine + new string('-', 80));

            // Сохраняем данные из MemoryStream в массив байт.
            byte[] array = memoryStream.ToArray();

            foreach (byte b in array)
            {
                Console.Write(" " + b);
            }

            Console.WriteLine(Environment.NewLine + new string('-', 80));

            // Сохраняем данные из MemoryStream в файл.
            FileStream file = new FileStream("Dump.txt", FileMode.Create, FileAccess.ReadWrite);
            memoryStream.WriteTo(file);

            // Переставляем внутренний указатель на начало.
            file.Position = 0;

            // Считывам байты из файла.
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write(" " + file.ReadByte());
            }
            // Закрываем memoryStream. 
            memoryStream.Close();
            
            //Закриваем файл
            file.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
