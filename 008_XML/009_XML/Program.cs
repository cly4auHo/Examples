using System;
using System.Text;
using System.Xml;

/// <summary>
/// Запись комментариев в XML файл.
/// </summary>
namespace _009_XML
{
    class Program
    {
        static void Main()
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("Books.xml", Encoding.GetEncoding(1251));

            xmlWriter.WriteStartDocument();                  // <?xml version="1.0"?>
            xmlWriter.WriteStartElement("ListOfBooks");      // <ListOfBooks>
            xmlWriter.WriteComment("Строка комментария.");
            xmlWriter.WriteEndElement();                     // </ListOfBooks>

            xmlWriter.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
