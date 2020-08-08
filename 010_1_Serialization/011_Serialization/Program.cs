using SerializableWork;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/// <summary>
/// Бинарная сериализация 
/// Для бинарной сериализации применяется класс BinaryFormatter:
/// </summary>
namespace _011_Serialization
{
    class Program
    {
        static void Main()
        {
            Mersedes auto = new Mersedes("CLK 500", 250, Mode.Lux);
            auto.TurnOnRadio(true);
            auto.ShowMode();

            Console.WriteLine(new string('-', 10));

            // Класс FileStream представляет возможности по считыванию из файла 
            // и записи в файл
            FileStream stream = File.Create("CarData.dat");

            // Для бинарной сериализации применяется класс BinaryFormatter:
            BinaryFormatter formatter = new BinaryFormatter();

            // Cериализация.
            formatter.Serialize(stream, auto);
            
            // Закрываем поток
            stream.Close();

            // Открывает существующий файл для чтения.
            stream = File.OpenRead("CarData.dat");

            // Десериализация.
            Mersedes autoDeserialize = formatter.Deserialize(stream) as Mersedes;

            Console.WriteLine("Имя     : " + autoDeserialize.Name);
            Console.WriteLine("Скорость: " + autoDeserialize.Speed);
            autoDeserialize.TurnOnRadio(false);

            // Закрываем поток
            stream.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
