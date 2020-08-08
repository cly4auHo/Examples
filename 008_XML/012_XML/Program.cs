using System;
using System.Xml;
using System.Xml.XPath;

/// <summary>
/// Создание навигаторов - XPathNavigator.
/// Редактирование файла при помощи навигатора.
/// </summary>
namespace _012_XML
{
    class Program
    {
        static void Main()
        {
            // Создание XPath документа.
            XPathDocument document = new XPathDocument("Books.xml");

            // Единственное назначение XPathDocument - создание навигатора.
            XPathNavigator navigator = document.CreateNavigator();

            // При создании навигатора при помощи XPathDocument 
            // возможно выполнять только чтение.
            Console.WriteLine(@"Навигатор создан только для чтения. 
                Свойство CanEdit = {0}.", 
                navigator.CanEdit);

            // Используя XmlDocument навигатор можно использовать и для редактирования.
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("Books.xml");

            navigator = xmldoc.CreateNavigator();
            Console.WriteLine(@"Навигатор получил возможность редактирования. 
                Свойство CanEdit = {0}.", navigator.CanEdit);

            // Теперь можно попробовать что-то записать в XML-документ.
            // Выполняем навигацию к узлу Book.
            navigator.MoveToChild("ListOfBooks", "");
            navigator.MoveToChild("Book", "");

            // Проводим вставку значений.
            navigator.InsertBefore("<InsertBefore>insert_before</InsertBefore>");
            navigator.InsertAfter("<InsertAfter>insert_after</InsertAfter>");
            navigator.AppendChild("<AppendChild>append_child</AppendChild>");

            navigator.MoveToNext("Book", "");

            navigator.InsertBefore("<InsertBefore>1111111111</InsertBefore>");
            navigator.InsertAfter("<InsertAfter>2222222222</InsertAfter>");
            navigator.AppendChild("<AppendChild>3333333333</AppendChild>");

            // Сохраняем изменения.
            xmldoc.Save("Books.xml");

            // Задержка.
            Console.ReadKey();
        }
    }
}
