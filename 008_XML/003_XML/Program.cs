using System;
using System.IO;
using System.Xml;

/// <summary>
/// Загрузка содержимого XML из строки.
/// Класс StreamReader позволяет нам легко считывать весь текст или отдельные строки из текстового файла.
/// </summary>
namespace _003_XML
{
    class Program
    {
        static void Main()
        {
            string xmlData = "<?xml version='1.0' encoding='utf-8' ?><Book><Title>CLR via C#</Title></Book>";

            // Класс StreamReader позволяет нам легко считывать весь текст или отдельные строки из текстового файла.
            StringReader stringReader = new StringReader(xmlData);
           
            // XmlReader методы позволяют перемещаться по XML-данным и читать содержимое узла. 
            XmlTextReader reader = new XmlTextReader(stringReader);

            // Считывает следующий узел из потока.
            while (reader.Read())
            {
                Console.WriteLine("{0,-15} {1,-10} {2,-10}",
                    reader.NodeType.ToString(), /*тип текущего узла*/
                    reader.Name,  /*полное имя текущего узла*/
                    reader.Value); /*текстовое значение текущего узла*/
            }

            // Закрываем StringReader
            reader.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
