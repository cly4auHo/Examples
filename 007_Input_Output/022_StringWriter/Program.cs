using System;
using System.IO;

/// <summary>
/// StringWriter - обертка над StringBuilder
/// </summary>
namespace _022_StringWriter
{
    class Program
    {
        static void Main()
        {
            // StringWriter - обертка над StringBuilder
            // StringWriter - Реализует объект System.IO.TextWriter для записи сведений в строку. Сведения
            // хранятся в базовом System.Text.StringBuilder.

            StringWriter writer = new StringWriter();
            
            writer.WriteLine("Hello all ");
            writer.Write("This is a multi-line ");
            writer.WriteLine("text string.");

            Console.WriteLine(writer.ToString());

            // Задержка.
            Console.ReadKey();
        }
    }
}
