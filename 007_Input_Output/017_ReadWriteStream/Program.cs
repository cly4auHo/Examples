using System;
using System.IO;

/// <summary>
/// Чтение/запись в потоки (streams).
/// Stream - класс, который имитирующий поток byte (байтов), выстроенные в ряд.
/// По сути, MemoryStream - это объект, который управляет буфером (buffer), - это массив байтов, 
/// когда байты записываются в этот поток, они автоматически будет прикреплены к следующей позиции 
/// от текущей позиции курсора в массиве. Когда буфер заполнен, создается новый массив большего 
/// размера и копируются данные из старого массива.
/// </summary>
namespace _017_ReadWriteStream
{
    class Program
    {
        static void Main()
        {
            // Создаем поток для работы с памятью.
            Stream stream = new MemoryStream();

            // Добавляем в поток данные.
            Console.WriteLine("Запись в поток начата...");

            byte[] byteArray = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            AppendToStream(stream, byteArray);

            Console.WriteLine("Данные успешно записаны!");

            // Считываем назад.
            Console.WriteLine(Environment.NewLine, "Содержимое потока:");
            DumpStream(stream);

            // Удаляем поток.
            stream.Close();

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Вывода содержимого потока на экран.
        /// </summary>
        static void DumpStream(Stream stream)
        {
            // Установить курсор на начало потока.
            stream.Position = 0;

            // Обработать поток в цикле и показать его содержимое.
            while (stream.Position != stream.Length)
            {
                Console.WriteLine("{0}", stream.ReadByte());
            }
        }

        /// <summary>
        ///  Добавления данных в поток.
        /// </summary>
        static void AppendToStream(Stream stream, byte[] data)
        {
            // Установить курсор в конец потока.
            stream.Position = stream.Length;

            // Добавить байты.
            stream.Write(data, 0, data.Length);
        }
    }
}
