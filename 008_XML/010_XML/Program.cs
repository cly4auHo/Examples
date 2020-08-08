using System;
using System.Xml;

/// <summary>
/// Запись в XML файл c форматированием.
/// </summary>
namespace _010_XML
{
    class Program
    {
        static void Main()
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("Books.xml", null);

            // Включить форматирование документа (с отступом).
            // Formatting.Indented - Заставляет дочерние элементы иметь отступ 
            xmlWriter.Formatting = Formatting.Indented;

            // Для выделения уровня элемента использовать табуляцию.
            // IndentChar - Получает или задает, какой символ использовать для отступа, 
            xmlWriter.IndentChar = '\n';

            // использовать один символ табуляции.
            xmlWriter.Indentation = 1;

            // Аналогично можно указать выравнивание с помощью четырех пробелов.
            //xmlWriter.IndentChar = ' ';
            //xmlWriter.Indentation = 4;

            // По умолчанию строки в XML файл записываются с помощью двойных кавычек.
            // Использование одиночных кавычек производится так:
            xmlWriter.QuoteChar = '\'';

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("ListOfBooks");
            xmlWriter.WriteStartElement("ListOfBooks", "http://localhost/test");
            xmlWriter.WriteStartElement("prefix", "ListOfBooks", "http://localhost/test");

            xmlWriter.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
