using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Использвание BufferedStream.
/// Буфер — это блок байтов памяти, который используется для кэширования данных, 
/// тем самым уменьшая количество обращений к операционной системе.
/// Таким образом, буферизация повышает скорость чтения и записи.
/// Методы Read и Write класса BufferedStream обслуживают буфер автоматически
/// </summary>
namespace _025_BufferedStream
{
    class Program
    {
        static void Main()
        {
            FileStream file = File.Create(@"D:\test.txt");

            // BufferedStream - Добавляет буферизацию для выполнения операций на другой поток чтения и записи.
            BufferedStream buffered = new BufferedStream(file);

            StreamWriter writer = new StreamWriter(buffered);

            writer.WriteLine("Some data...");

            buffered.Position = 0;

            // При сбросе буфера buffered, данные из него попадают в связанный поток - file.
            writer.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
