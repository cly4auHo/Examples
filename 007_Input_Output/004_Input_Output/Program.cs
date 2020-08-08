using System;
using System.IO;

/// <summary>
/// Directory - Информация о дисках (GetLogicalDrives()).
/// Directory - Удаление директорий (Delete).
/// </summary>
namespace _004_Input_Output
{
    class Program
    {
        static void Main()
        {
            // Извлекает имена логических устройств данного компьютера в формате.
            string[] logicalDrives = Directory.GetLogicalDrives();

            Console.WriteLine("Имеющиеся диски:");

            foreach (var drive in logicalDrives)
            {
                Console.WriteLine(drive);
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(new string('-',30));

            DirectoryInfo directory = new DirectoryInfo(@"E:\Програмирование\ITEA Курс по С#\New_Version\ITEA - Продвинутый курс по С#\007_Ввод-вывод\Testing");

            Console.WriteLine("Будут удалены следующие директории:");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(directory.FullName + @"\MyDir\SubMyDir");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(directory.FullName + @"\SUBDIR");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Нажмите Enter для удаления");
            Console.WriteLine(Environment.NewLine);

            // Задержка перед удалением.
            Console.ReadKey();

            try

            {
                // Удаляет каталог по заданному пути.
                Directory.Delete(@"E:\Програмирование\ITEA Курс по С#\New_Version\ITEA - Продвинутый курс по С#\007_Ввод-вывод\Testing\SUBDIR");

                // Удаляет каталог по заданному пути
                // Второй параметр определяет, будут ли удалены также и все вложенные подкаталоги. 
                Directory.Delete(@"E:\Програмирование\ITEA Курс по С#\New_Version\ITEA - Продвинутый курс по С#\007_Ввод-вывод\Testing\MyDir", true);

                Console.WriteLine("Каталоги успешно удалены.");
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
