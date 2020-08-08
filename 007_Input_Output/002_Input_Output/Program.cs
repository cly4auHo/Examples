using System;
using System.IO;

/// <summary>
/// Подобно Directory для работы с файлами предназначена класс FileInfo. 
/// С его помощью мы можем создавать, удалять, перемещать файлы, получать их свойства и многое другое.
/// </summary>
namespace _002_Input_Output
{
    class Program
    {
        static void Main()
        {
            Console.WindowWidth = 150;

            DirectoryInfo directory = new DirectoryInfo(@".");

            // Проверка на существование указанной директории.
            if (directory.Exists)
            {
                // Полное Имя директории, (включая путь).
                Console.WriteLine("FullName    : {0}", directory.FullName);
                // Имя директории, (НЕ включая путь).
                Console.WriteLine("Name        : {0}", directory.Name);
                // Родительская директория. 
                Console.WriteLine("Parent      : {0}", directory.Parent);
                // Время создания директории.
                Console.WriteLine("CreationTime: {0}", directory.CreationTime);
                // Аттрибуты.
                Console.WriteLine("Attributes  : {0}", directory.Attributes.ToString());
                // Корневой диск, на котором находится директория.
                Console.WriteLine("Root        : {0}", directory.Root);

                Console.Write(Environment.NewLine);
                Console.WriteLine(new string('-', 30));

                // Получаем все файлы с расширением .txt.
                FileInfo[] files = directory.GetFiles("*.txt");

                // Сколько файлов с расширением .txt в данной директории.
                Console.WriteLine("Найдено {0} *.txt файлов\n", files.Length);

                // Выводим информацию о каждом файле.
                foreach (FileInfo file in files)
                {
                    // Имя файла.
                    Console.WriteLine("File name : {0}", file.Name);
                    // Размер текущего файла в байтах.
                    Console.WriteLine("File size : {0}", file.Length);
                    // Время создания текущего файла или каталога.
                    Console.WriteLine("Creation  : {0}", file.CreationTime);
                    // Аттрибуты.
                    Console.WriteLine("Attributes: {0}", file.Attributes.ToString());
                    
                    Console.Write(Environment.NewLine);
                }
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
