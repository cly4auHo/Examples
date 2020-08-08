using System;
using System.Text;

/// <summary>
/// Методы StringBuilder:
/// </summary>
namespace _029_StringBuilder
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Append("!");
            sb.Insert(7, "компьютерный ");
            Console.WriteLine(sb);

            // заменяем слово
            sb.Replace("мир", "world");
            Console.WriteLine(sb);

            // удаляем 13 символов, начиная с 7-го
            sb.Remove(7, 13);
            Console.WriteLine(sb);

            // получаем строку из объекта StringBuilder
            string @string = sb.ToString();
            Console.WriteLine(@string);

            Console.ReadKey();
        }
    }
}
