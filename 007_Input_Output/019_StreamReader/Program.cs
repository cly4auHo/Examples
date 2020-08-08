using System;
using System.IO;

/// <summary>
/// Поиск по файлу.
/// Для тестирования данного примера создайте файл! (Укажите правильное расположение файла!)
/// Запишите в файл следующие строки:
/// Hello 
/// people!
/// How
/// are
/// you?
/// </summary>
namespace _019_StreamReader
{
    class Program
    {
        static void Main()
        {
            // Подготовка файла.
            StreamReader reader = File.OpenText(@"D:\ITEA - Продвинутый курс по С#\008_Ввод-вывод\Пример\Новый текстовый документ.txt");

            // Последовательный обход файла.
            while (!reader.EndOfStream)
            {
                // Чтение файла построчно.
                string line = reader.ReadLine();

                // Если нужный текст найден, прекратить чтение.
                if (line != null && line.Contains("people"))
                {
                    // Обнаружив слово "Andrew", уведомить пользователя и прекратить чтение файла.
                    Console.WriteLine("Found:");
                    Console.WriteLine(line);
                    break;
                }
            }

            //  Очистка.
            reader.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
