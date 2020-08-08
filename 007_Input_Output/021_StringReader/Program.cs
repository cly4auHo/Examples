using System;
using System.IO;

/// <summary>
/// Чтение из потока.
/// </summary>
namespace _021_StringReader
{
    class Program
    {
        static void Main()
        {
            string stringRow = "Hello all!" + Environment.NewLine + "This is a multi-line text string." + Environment.NewLine + Environment.NewLine + "cdscd";

            // StringReader - реализует System.IO.TextReader считывает данные из строки.
            StringReader reader = new StringReader(stringRow);

            // Метод Peek возвращает целочисленное значение, чтобы определить, произошла ошибка или достигнут конец файла.
            // Это позволяет пользователю сначала проверить, не равно ли возвращенное значение -1, прежде чем приводить его к типу Char.
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
