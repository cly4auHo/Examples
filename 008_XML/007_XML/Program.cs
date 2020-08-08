using System;
using System.Xml;

/// <summary>
/// Запись атрибутов.
/// Запись XML с помощью класса XmlWriter
/// </summary>
namespace _007_XML
{
    class Program
    {
        static void Main()
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("Books.xml", null);

            // Заголовок XML - <?xml version="1.0"?>
            xmlWriter.WriteStartDocument();
            // Корневой элемент - <ListOfBooks>
            xmlWriter.WriteStartElement("ListOfBooks");
            // Книга 1 - <Book
            xmlWriter.WriteStartElement("Book");
            // Атрибут - FontSize
            xmlWriter.WriteStartAttribute("FontSize");
            //= "8"
            xmlWriter.WriteString("8");
            // >
            xmlWriter.WriteEndAttribute();
            // Title-1
            xmlWriter.WriteString("CLR via C# Рихтер");
            // </Book>
            xmlWriter.WriteEndElement();
            // </ListOfBooks>
            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
