using System;
using System.Xml;

/// <summary>
/// Запись данных в XML файл.
/// </summary>
namespace _008_XML
{
    class Program
    {
        static void Main()
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("Books.xml", null);

            xmlWriter.WriteStartDocument();                  //  <?xml version="1.0"?>
            xmlWriter.WriteStartElement("ListOfBooks");      //  <ListOfBooks>
            xmlWriter.WriteStartElement("Book");             //  <Book>
            xmlWriter.WriteString("CLR via C# Рихтер");      //  CLR via C# Рихтер
            xmlWriter.WriteEndElement();                     //  </Book>
            xmlWriter.WriteStartElement("Book");             //  <Book>
            xmlWriter.WriteString("C# Language Troelsen");   //  C# Language Troelsen
            xmlWriter.WriteEndElement();                     //  </Book>   
            xmlWriter.WriteStartElement("Book");             //  <Book>
            xmlWriter.WriteString("Language C# Shildt");     //  Language C# Shildt
            xmlWriter.WriteEndElement();                     //  </Book>   
            xmlWriter.WriteEndElement();                     //  </ListOfBooks>

            xmlWriter.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
