using System;
using System.IO;

/// <summary>
/// Для работы с каталогами в пространстве имен System.IO предназначен класс: Directory
/// Класс Directory предоставляет ряд статических методов для управления каталогами.
/// </summary>
namespace _001_Input_Output
{
    class Program
    {
        static void Main()
        {
            // Экземпляр класса DirectoryInfo, ссылается на директорию - C:\Windows\assembly. 
            DirectoryInfo directory = new DirectoryInfo(@"C:\Windows\assembly");

            // Вывод информации о каталоге (Директории).
            // Если указанная директория существует, то выводим о ней информацию.
            if (directory.Exists) 
            {
                // Полное Имя директории, (включая путь).
                Console.WriteLine("FullName      : {0}", directory.FullName);
                // Имя директории, (НЕ включая путь).
                Console.WriteLine("Name          : {0}", directory.Name);
                // Родительская директория. 
                Console.WriteLine("Parent        : {0}", directory.Parent);
                // Время создания директории.
                Console.WriteLine("CreationTime  : {0}", directory.CreationTime);
                // Аттрибуты.
                Console.WriteLine("Attributes    : {0}", directory.Attributes.ToString());
                // Корневой диск, на котором находится директория.
                Console.WriteLine("Root          : {0}", directory.Root);
                // Время последнего доступа к директории.
                Console.WriteLine("LastAccessTime: {0}", directory.LastAccessTime);
                // Время последнего изменения файлов в директории.
                Console.WriteLine("LastWriteTime : {0}", directory.LastWriteTime);
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
