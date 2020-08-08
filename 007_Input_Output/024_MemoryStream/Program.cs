using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Использование MemoryStream.
/// </summary>
namespace _024_MemoryStream
{
    class Program
    {
        static void Main()
        {
            MemoryStream memory = new MemoryStream();

            StreamWriter writer = new StreamWriter(memory);

            writer.WriteLine("Hello");
            writer.WriteLine("GoodBye");

            // Приказать объекту-записи writer, переписать данные в поток - memory.
            // Flush() - очищает все буферы для текущего средства записи и вызывает запись всех данных буфера в основной поток.
            writer.Flush();

            // Создать файловый поток.
            FileStream file = File.Create(@"D:\test.txt");

            // Переписать содержимое потока памяти в файл целиком.
            memory.WriteTo(file);

            // Освободить ресурсы.
            writer.Close();
            file.Close();
            memory.Close();

            // Delay.
            Console.ReadKey();
        }
    }
}
