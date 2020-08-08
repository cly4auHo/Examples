using System;
using System.IO;

/// <summary>
/// С помощью класса FileInfo мы можем создавать, удалять, перемещать файлы, получать свойства файлов.
/// Копирование файлов.
/// CopyTo - CopyTo(path): копирует файл в новое место по указанному пути path
/// </summary>
namespace _011_FileInfo_Copy
{
    class Program
    {
        static void Main()
        {
            // Создаем объект для работы с файлом.
            FileInfo file = new FileInfo(@"C:\Windows\notepad.exe");

            // Копируем содержимое файла.
            try
            {
                file.CopyTo(@"D:\aaaa.exe");
                Console.WriteLine("Файл успешно скопирован!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
