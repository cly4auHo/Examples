using System.IO;
using System.IO.Compression;

/// <summary>
/// Сжатие файлов.
/// DeflateStream
/// </summary>
namespace _028_DEFLATE_Compression
{
    class Program
    {
        static void Main()
        {
            
            // Создание файла и архива.
            // Файл из которого будем делать архив
            FileStream source = File.OpenRead(@"D:\test.txt");
            // Создаем файл "архив"
            FileStream destination = File.Create(@"D:\archive.dfl");

            // Создание компрессора.
            //Предоставляет методы и свойства для сжатия и распаковки потоков с использованием
            //     алгоритма Deflate.
            DeflateStream compressor = new DeflateStream(destination, CompressionMode.Compress);

            // Заполнение архива информацией из файла.
            int theByte = source.ReadByte();

            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }

            // Удаление компрессора.
            compressor.Close();
        }
    }
}
