using System;
using System.Xml.XPath;

/// <summary>
/// XPath представляет язык запросов в XML. 
/// Он позволяет выбирать элементы, соответствующие определенному селектору.
/// </summary>
namespace _011_XML
{
    class Program
    {
        static void Main()
        {
            // Создание XPath документа.
            XPathDocument document = new XPathDocument("Books.xml");

            // Класс XPathNavigator содержит набор методов, используемых для 
            // выборки набора узлов в объекте XPathDocument или XmlDocument 
            // с помощью выражения XPath. По набору выбранных узлов можно 
            // передвигаться в цикле итерации.
            XPathNavigator navigator = document.CreateNavigator();

            // Прямой запрос XPath.
            XPathNodeIterator dataSource1 = navigator.Select("ListOfBooks/Book/Title");

            foreach (var row in dataSource1)
            {
                Console.WriteLine(row);
            }

            // Оттеняем вывод
            Console.WriteLine(new string('-', 20));

            // Скомпилированный запрос XPath
            // Compile - Компилирует строку, представляющую выражение XPath, 
            // и возвращает System.Xml.XPath.XPathExpression.
            XPathExpression expression = navigator.Compile("ListOfBooks/Book[2]/Price");
            XPathNodeIterator dataSource2 = navigator.Select(expression);

            foreach (var row in dataSource2)
            {
                Console.WriteLine(row);
            }

            //Задержка
            Console.ReadKey();
        }
    }
}
