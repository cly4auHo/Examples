using System;
using System.IO;

/// <summary>
/// Класс FileStream представляет возможности по считыванию из файла и записи в файл. 
/// </summary>
namespace _007_Input_Output
{
    class Program
    {
        static void Main()
        {
            // Создаем файл в текущем каталоге.
            FileStream stream = new FileStream("Test.txt", 
                FileMode.OpenOrCreate, 
                FileAccess.ReadWrite);

            // Этот массив соответствует: {'H','e','l','l','o',' ','W','o','r','l','d'}.
            byte[] bytes = new byte[] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 };

            // Записываем байты в файл.
            for (int i = 0; i < bytes.Length; i++)
            {
                stream.WriteByte(bytes[i]);
            }

            Console.WriteLine(stream.Position);
          
            // Переставляем внутренний указатель на начало.
            stream.Position = 0;

            // Считывам байты из файла.
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write(" " + stream.ReadByte());
            }

            // Закрываем FileStream. 
            stream.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
