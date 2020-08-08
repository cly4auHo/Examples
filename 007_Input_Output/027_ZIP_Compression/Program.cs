using System.IO;
using System.IO.Compression;

/// <summary>
/// Сжатие файлов.
/// GZipStream
/// </summary>
namespace _027_ZIP_Compression
{
    class Program
    {
        static void Main()
        {
            // Создание файла и архива.
            // Файл из которого будем делать архив
            FileStream source = File.OpenRead(@"D:\test.txt");
            // Создаем файл "архив"
            FileStream destination = File.Create(@"D:\archive.zip");

            // Создание компрессора.
            // GZipStream - Предоставляет методы и свойства, используемые для сжатия и распаковки потоков.
            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

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
