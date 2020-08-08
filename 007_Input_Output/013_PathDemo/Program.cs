using System;
using System.IO;

/// <summary>
///  Работа с классом Path.
///  Для класса Path создавать экземпляры не нужно. 
///  Он предоставляет статические методы, которые упрощают выполнение операций с путевыми именами. 
/// </summary>
namespace _013_PathDemo
{
    class Program
    {
        static void Main()
        {
            // Создание строки, содержащей адрес.
            string path = string.Format(@"C:\Windows\notepad");
            Console.WriteLine(path);

            // Вывод на экран значений свойств класса-объекта Path.
            Console.WriteLine("Ext: {0}", Path.GetExtension(path));

            // ChangeExtension не изменяет расширение у файла — он просто создает строку с другим расширением, 
            // которую вы сами должны использовать для реального переименования (например, через статический метод Move класса File) 
            Console.WriteLine("Change Path: {0}", path = Path.ChangeExtension(path, "bak"));
            Console.WriteLine(path);

            // Задержка.
            Console.ReadKey();
        }
    }
}
