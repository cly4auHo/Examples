using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _005_NonSerialized
{
    class Program
    {
        static void Main()
        {
            ShoppingCartItem shoppingCart = new ShoppingCartItem(2534681, 50000, 5);

            // Сериализация
            FileStream stream = new FileStream("SerializedCar.txt", FileMode.Create);
            
            BinaryFormatter formatter = new BinaryFormatter();
            
            formatter.Serialize(stream, shoppingCart);
            
            stream.Close();

            //Десереализация 
            stream = new FileStream("SerializedCar.txt", FileMode.Open);
            formatter = new BinaryFormatter();
            shoppingCart = (ShoppingCartItem)formatter.Deserialize(stream);
            stream.Close();

            // Отображаем десериализованную строку.
            Console.WriteLine("Total : {0}", shoppingCart.total);

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
