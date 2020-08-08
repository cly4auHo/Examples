using System;
using System.IO;

/// <summary>
/// Класс FileStream представляет возможности по считыванию из файла и записи в файл. 
/// С помощью класса FileInfo мы можем создавать, удалять, перемещать файлы, получать свойства файлов.
/// </summary>
namespace _006_Input_Output
{
    class Program
    {
        static void Main()
        {
            // Создаем новый файл:
            FileInfo file = new FileInfo(@"E:\Програмирование\ITEA Курс по С#\New_Version\ITEA - Продвинутый курс по С#\007_Ввод-вывод\Testing\Test.txt");

            // FileMode.OpenOrCreate - ЕСЛИ: существует ТО: открыть ИНАЧЕ: создать новый
            // FileAccess.Read - только для чтения,
            // FileShare.None - Совместный доступ - Нет.
            FileStream stream = file.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);

            // Выводим основную информацию о созданном файле.            
            Console.WriteLine("Full Name   : {0}", file.FullName);
            Console.WriteLine("Attributes  : {0}", file.Attributes.ToString());
            Console.WriteLine("CreationTime: {0}", file.CreationTime);

            Console.WriteLine("Нажмите любую клавишу для удаления файла.");
            
            Console.ReadKey();

            // Закрываем FileStream. 
            stream.Close();

            // Удаляем файл.
            file.Delete();

            Console.WriteLine("Файл успешно удален.");

            // Задержка.
            Console.ReadKey();
        }
    }
}
