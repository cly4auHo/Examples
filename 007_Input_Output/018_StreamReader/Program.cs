using System;
using System.IO;

/// <summary>
/// Работа с классом StreamReader. Различные способы получения информации из файла.
/// 
/// Чтобы работать с файлом как хранилищем символов предназначены классы StreamWriter и StreamReader. 
/// Оба класса наследуются от TextWriter и TextReader соответственно, функционал которых 
/// расширен для работы с файловыми потоками.
/// 
/// Класс FileStream представляет возможности по считыванию из файла и записи в файл. 
/// Он позволяет работать как с текстовыми файлами, так и с бинарными.
/// </summary>
namespace _018_StreamReader
{
    class Program
    {
        static void Main()
        {

            // Открываем файл для чтения.
            // FileMode - Указывает, каким образом операционная система должна открыть файл.
            // FileAccess - Определяет константы для чтения, записи или чтения и записи в файл.
            // FileAccess.ReadWrite - чтение и запись в файл.
            FileStream file = File.Open(@"D:\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // Создаем поток для чтения данных из файла.
            StreamReader reader = new StreamReader(file);

            // Читаем до конца.
            Console.Write(reader.ReadToEnd());

            // Закрываем файл и удаляем поток.
            reader.Close();

            //file.Close(); // Закрывать не обязательно так как reader закроет сам.

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(new string('-', 30));
            

            // Еще раз открываем файл, используя другой способ.
            reader = File.OpenText(@"D:\test.txt");

            // Читаем до конца и закрываем файл.
            Console.Write(reader.ReadToEnd());

            reader.Close();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(new string('-', 30));
            

            // Читаем весь текст, содержащийся в файле.
            Console.WriteLine(File.ReadAllText(@"D:\test.txt"));

            // Задержка.
            Console.ReadKey();
        }
    }
}
