﻿using System;
using System.IO;
using System.Xml.Serialization;

/// <summary>
///    Чтобы создать класс, который можно сериализовать в формат XML, 
///    нужно выполнить следующее:
///    1) объявить класс как открытый(public)
///    2) объявить все члены, которые нужно сериализовать, как открытые(public)
///    3) создать конструктор по умолчанию(без параметров)
/// </summary>

namespace _007_ClassSerializationXML
{
    class Program
    {
        static void Main()
        {
            ShoppingCatItem item = new ShoppingCatItem 
                {
                    productId = 22, 
                    price = 50000, 
                    quantity = 2 
                };

            item.total = item.quantity * item.price;

            // Создаем файл для сохранения данных
            FileStream stream = new FileStream("SerializedClass.xml", FileMode.Create);

            // Создаем объект XmlSerializer для выполнения сериализации
            XmlSerializer serializer = new XmlSerializer(typeof(ShoppingCatItem));

            // Используем объект XmlSerializer для сериализации данных в файл
            serializer.Serialize(stream, item);

            // Закрываем файл
            stream.Close();
        }
    }

    public class ShoppingCatItem
    {
        public Int32 productId;
        public decimal price;
        public Int32 quantity;
        public decimal total;
    }

}
