using System;
using System.IO;

/// <summary>
/// Для записи в текстовый файл используется класс StreamWriter. 
/// </summary>
namespace _009_Input_Output
{
    class Program
    {
        static void Main()
        {
            // Создаем файл.
            var file = new FileInfo("Text.txt");

            // С помощью экземпляра StreamWriter записываем в файл несколько строк текста. 
            StreamWriter writer = file.CreateText();

            writer.WriteLine("Первая строка текста...");
            writer.WriteLine("Вторая строка текста...");

            // Вставляем символ начала новой строки.
            writer.Write(writer.NewLine);

            writer.WriteLine("Третья строка чисел:");

            for (int i = 0; i < 10; i++)
            {
                writer.Write(i + " ");
            }

            // Вставляем символ начала новой строки.
            writer.Write(writer.NewLine);

            // Метод Close() автоматически очищает все буферы!
            writer.Close();

            Console.WriteLine("Файл Text.txt создан и в него записан текст.");

            // Задержка.
            Console.ReadKey();
        }
    }
}
