using System;
using System.Xml;

/// <summary>
/// Чтение атрибутов.
/// </summary>
namespace _006_XML
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
                    //Получает значение, указывающее, имеет ли текущий узел какие-либо атрибуты.
                    if (reader.HasAttributes)
                    {
                        //Переходит к следующему атрибуту.
                        while (reader.MoveToNextAttribute())
                        {
                            Console.WriteLine("{0} = {1}", 
                                reader.Name,   /*полное имя текущего узла*/
                                reader.Value); /*текстовое значение текущего узла*/
                        }
                    }
                }
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
