using System;
using System.IO;

/// <summary>
/// Класс FileStream представляет возможности по считыванию из файла и записи в файл. 
/// </summary>
namespace _005_Input_Output
{
    class Program
    {
        static void Main()
        {
            // Создаем новый файл в корне диска E:
            FileInfo file = new FileInfo(@"E:\Програмирование\ITEA Курс по С#\New_Version\ITEA - Продвинутый курс по С#\007_Ввод-вывод\Testing\Test.txt");

            //Создает файл.
            FileStream stream = file.Create();
            
            // Выводим основную информацию о созданном файле.
            Console.WriteLine("Full Name   : {0}", file.FullName);
            Console.WriteLine("Attributes  : {0}", file.Attributes.ToString());
            Console.WriteLine("CreationTime: {0}", file.CreationTime);

            stream.Close();

            Console.WriteLine("Нажмите любую клавишу для удаления файла.");
            Console.ReadKey();

            // Удаляем файл.
            file.Delete();

            Console.WriteLine("Файл успешно удален.");

            // Задержка.
            Console.ReadKey();
        }
    }
}
