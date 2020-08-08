using System;
using System.Xml.Linq;

/// <summary>
/// Еще один подход к работе с Xml представляет технология LINQ to XML.
/// </summary>
namespace _014_XML
{
    class Program
    {
        static void Main()
        {
            XDocument xdoc = new XDocument();

            // создаем корневой элемент
            XElement BookList = new XElement("ListOfBooks");

            // создаем первый элемент
            XElement Book1 = new XElement("Book");

            // создаем атрибут
            //XAttribute Titleattribute = new XAttribute("Title", "CLR via C# Рихтер");
            XElement Titleattribute = new XElement("Title", "CLR via C# Рихтер");
            XElement Priceattribute = new XElement("Price", "999");

            // добавляем атрибут и элементы в первый элемент
            Book1.Add(Titleattribute);
            Book1.Add(Priceattribute);

            // добавляем в корневой элемент
            BookList.Add(Book1);

            // добавляем корневой элемент в документ
            xdoc.Add(BookList);

            //сохраняем документ
            xdoc.Save("Books.xml");

            // Задержка.
            Console.ReadKey();
        }
    }
}
