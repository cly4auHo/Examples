using System;
using System.IO;

/// <summary>
/// DriveInfo
/// Помимо работы с файлами и каталогами, в .NET Framework предоставляется возможность читать 
/// информацию об указанном диске. Для этого предусмотрен класс DriveInfo. Этот класс умеет 
/// производить сканирование системы и составлять список всех доступных в ней дисков, 
/// а также детальные сведения о любом из них.
/// </summary>
namespace _012_DriveInfoDemo
{
    class Program
    {
        static void Main()
        {
            // Создание коллекции дисков.
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Вывод информации о дисках компьютера.
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Drive: {0} Type: {1}", drive.Name, drive.DriveType);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
