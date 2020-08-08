using System;
using System.Linq;
using System.Xml.Linq;

/// <summary>
/// Изменение документа в LINQ to XML
/// </summary>
namespace _016_XML
{
    class Program
    {
        static void Main()
        {
            XDocument document = XDocument.Load("Books.xml");

            XElement root = document.Element("ListOfBooks");
            var dataSourse = root.Elements("Book").ToList();

            foreach (XElement row in dataSourse)
            {
                if (row.Element("Title").Value == "CLR via C# Рихтер")
                {
                    Console.WriteLine("Установить новую цену!");
                    row.Element("Price").Value = "1500";
                }
            }

            document.Save("Books.xml");

            Console.ReadKey();
        }
    }
}
