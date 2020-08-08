using System;
using System.IO;

/// <summary>
/// Для работы с каталогами в пространстве имен System.IO предназначены два класса: Directory и DirectoryInfo.
/// Класс DirectoryInfo предоставляет функциональность для создания, удаления, перемещения и других операций 
/// с каталогами. Во многом он похож на Directory. Некоторые из его свойств и методов:
/// </summary>
namespace _003_Input_Output
{
    class Program
    {
        static void Main()
        {
            Console.WindowWidth = 150;

            DirectoryInfo directory = new DirectoryInfo(@"E:\Програмирование\ITEA Курс по С#\New_Version\ITEA - Продвинутый курс по С#\007_Ввод-вывод\Testing");

            if (directory.Exists)
            {
                // Cоздает подкаталог
                // CreateSubdirectory - создает подкаталог по указанному пути
                DirectoryInfo directoryInfoSubdir = directory.CreateSubdirectory("SUBDIR");

                if (directoryInfoSubdir.Exists)
                {
                    Console.WriteLine(string.Format(@"Директория {0} успешно создана", directoryInfoSubdir.Name));
                    Console.Write(Environment.NewLine);

                    Console.WriteLine("FullName    : {0}", directoryInfoSubdir.FullName);
                    Console.WriteLine("Name        : {0}", directoryInfoSubdir.Name);
                    Console.WriteLine("Parent      : {0}", directoryInfoSubdir.Parent);
                    Console.WriteLine("CreationTime: {0}", directoryInfoSubdir.CreationTime);
                    Console.WriteLine("Attributes  : {0}", directoryInfoSubdir.Attributes.ToString());
                    Console.WriteLine("Root        : {0}", directoryInfoSubdir.Root);

                    Console.Write(Environment.NewLine);
                    Console.WriteLine(new string('-', 30));
                }

                // Cоздает подкаталогв полкаталоге
                // CreateSubdirectory - создает подкаталог по указанному пути
                DirectoryInfo directoryInfoSubMyDir = directory.CreateSubdirectory(@"MyDir\SubMyDir");

                if (directoryInfoSubMyDir.Exists)
                {
                    Console.WriteLine(string.Format(@"Директория {0} успешно создана", directoryInfoSubMyDir.Name));
                    Console.Write(Environment.NewLine);

                    Console.WriteLine("FullName    : {0}", directoryInfoSubMyDir.FullName);
                    Console.WriteLine("Name        : {0}", directoryInfoSubMyDir.Name);
                    Console.WriteLine("Parent      : {0}", directoryInfoSubMyDir.Parent);
                    Console.WriteLine("CreationTime: {0}", directoryInfoSubMyDir.CreationTime);
                    Console.WriteLine("Attributes  : {0}", directoryInfoSubMyDir.Attributes.ToString());
                    Console.WriteLine("Root        : {0}", directoryInfoSubMyDir.Root);

                    Console.Write(Environment.NewLine);
                    Console.WriteLine(new string('-', 30));
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
