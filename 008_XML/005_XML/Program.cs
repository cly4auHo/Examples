using System;
using System.Xml;

/// <summary>
/// Чтение атрибутов.
/// Задача получения FontSize для каждого елемента книги
/// </summary>
namespace _005_XML
{
    class Program
    {
        static void Main()
        {
            //XmlReader методы позволяют перемещаться по XML-данным и читать содержимое узла.
            XmlTextReader reader = new XmlTextReader("Books.xml");

            // Считывает следующий узел из потока.
            while (reader.Read())
            {
                //Если тип текущего узла = типу узла .Элемент
                if (reader.NodeType == XmlNodeType.Element)
                {
                    // Проверка на тип узла необходима, иначе будут найдены не только открывающие элементы (XmlNodeType.Element),
                    // но и закрывающие (XmlNodeType.EndElement).
                    if (reader.Name.Equals("Title"))   // Закомментировать и выполнить.
                    {
                        // Возвращает значение атрибута с указанным именем.
                        Console.WriteLine(reader.GetAttribute("FontSize"));
                    }
                }
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
