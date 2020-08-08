using System;
using System.Xml;

/// <summary>
/// Обход всех элементов XML файла.
/// XmlNode: представляет узел xml. В качестве узла может использоваться весь документ, 
/// так и отдельный элемент
/// </summary>
namespace _004_XML_
{
    class Program
    {
        static void Main()
        {
            // Загрузка XML из файла.
            XmlDocument document = new XmlDocument();

            // Загружает XML-документ из указанного адреса.
            document.Load("Books.xml");

            // Представляет отдельный узел в XML-документе.
            XmlNode root = document.DocumentElement;

            // Напечатает "document.DocumentElement=ListOfBooks"
            Console.WriteLine("document.DocumentElement = {0}\n", root.LocalName);

            // ChildNodes - Возвращает все дочерние узлы данного узла.
            foreach (XmlNode books in root.ChildNodes)
            {
                Console.WriteLine("Found Book:");
                foreach (XmlNode book in books.ChildNodes)
                {
                    // При переопределении в производном классе возвращает полное имя узла.
                    // InnerText - Возвращает или задает связанные значения узла и всех его дочерних узлов.
                    Console.WriteLine(book.Name + ": " + book.InnerText);
                }

                // Оттеняем вывод
                Console.WriteLine(new string('-', 40));
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
