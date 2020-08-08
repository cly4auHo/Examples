using System;
using System.Xml;

/// <summary>
/// XmlDocument: представляет весь xml-документl;
/// XmlDocument - позволяет загрузить в себя XML файл и 
/// считать его содержимое через свойства
/// </summary>
namespace _001_XML
{
    class Program
    {
        static void Main()
        {
            // Загрузка XML из файла.
            XmlDocument document = new XmlDocument();
            document.Load("Books.xml");

            // Показ содержимого XML.
            Console.WriteLine(document.InnerText);

            // Оттеняем вывод
            Console.WriteLine(new string('-', 20));

            // Показ кода XML документа.
            Console.WriteLine(document.InnerXml);

            // Задержка.
            Console.ReadKey();
        }
    }
}
