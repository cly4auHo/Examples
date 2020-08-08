using System;
using System.IO;
using System.Xml;

/// <summary>
/// Загрузка содержимого XML из файла.
/// XmlReader предоставляет доступ к XML-данным в документе или потоке.
/// XmlReader методы позволяют перемещаться по XML-данным и читать содержимое узла. 
/// </summary>
namespace _002_XML
{
    class Program
    {
        static void Main()
        {
            // Класс FileStream представляет возможности по считыванию 
            // из файла и записи в файл
            FileStream stream = new FileStream("Books.xml", FileMode.Open);

            //XmlReader методы позволяют перемещаться по XML-данным и читать содержимое узла. 
            XmlTextReader xmlReader = new XmlTextReader(stream);
            
            //Считывает следующий узел из потока.
            while (xmlReader.Read())
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}",
                    xmlReader.NodeType, /*тип текущего узла*/
                    xmlReader.Name, /*полное имя текущего узла*/
                    xmlReader.Value); /*текстовое значение текущего узла*/
            }

            // Закрываем XmlTextReader
            xmlReader.Close();

            // Закрываем поток
            stream.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
