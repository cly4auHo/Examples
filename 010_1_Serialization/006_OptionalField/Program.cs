﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _006_OptionalField
{
    class Program
    {
        static void Main()
        {
            FileStream stream = new FileStream("SerializedCar.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            ShoppingCartItem item = (ShoppingCartItem)formatter.Deserialize(stream);
            stream.Close();

            // Отображаем десериализованную строку.
            Console.WriteLine("Taxable : {0}", item.taxable);

            // Задержка.
            Console.ReadKey();
        }
    }

    [Serializable]
    class ShoppingCartItem : IDeserializationCallback
    {
        public int productId;
        public decimal price;
        public int quantity;
        [NonSerialized]
        public decimal total;

        // Поле добавленное в класс в новой версии. 
        // Инициализируется значением по умолчанию.
        [OptionalField]
        public bool taxable;

        public ShoppingCartItem(int _productId, decimal _price, int _quantity)
        {
            productId = _productId;
            price = _price;
            quantity = _quantity;
            //total = price * quantity;
        }

        void IDeserializationCallback.OnDeserialization(object sender)
        {
            // После десериализации подсчитываем общую стоимость.
            total = price * quantity;
        }
    }
}
