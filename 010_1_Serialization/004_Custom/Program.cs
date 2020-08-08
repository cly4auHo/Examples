using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UserSerialWork;

/// <summary>
///  Пользовательская сериализация.
///  ISerializable - Позволяет объекту управлять собственной сериализацией 
///  и десериализацией.
/// </summary>
namespace _004_Custom
{
    class Program
    {
        static void Main()
        {
            Car car = new Car("Mersedes-Benz", 250);
            Stream stream = File.Create("CarData.dat");

            BinaryFormatter formatter = new BinaryFormatter();

            // Сериализация (Вызов метода ISerializable.GetObjectData()).
            formatter.Serialize(stream, car);

            stream.Close();

            stream = File.OpenRead("CarData.dat");

            // Десериализация (Вызов спецконструктора).
            car = formatter.Deserialize(stream) as Car;

            Console.WriteLine(car.name + "\n" + car.speed);

            // Задержка. 
            Console.ReadKey();
        }
    }
}
