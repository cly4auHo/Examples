using SerializableWork;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

/// <summary>
/// Бинарная сериализацию в C#.
/// Класс "SoapFormatter" сохраняет объект в формате "SOAP" 
/// (XML-формат для приема и передачи сообщений от веб-служб).
/// </summary>
namespace _003_SOAP
{
    class Program
    {
        static void Main()
        {
            // Создаём экземпляр класса
            Mersedes auto = new Mersedes("G500", 250, Mode.Lux);
            auto.TurnOnRadio(true);
            auto.ShowMode();

            // Класс FileStream представляет возможности по считыванию из файла 
            // и записи в файл
            FileStream stream = File.Create("CarData.xml");

            // Помещаем объектный граф (для базовых типов) в поток в двоичном формате.
            SoapFormatter formatter = new SoapFormatter();

            // Cериализация.
            formatter.Serialize(stream, auto);

            // Закрываем поток
            stream.Close();

            // Открывает существующий файл для чтения.
            stream = File.OpenRead("CarData.xml");

            // Десериализация.
            auto = formatter.Deserialize(stream) as Mersedes;

            Console.WriteLine("Имя     : " + auto.Name);
            Console.WriteLine("Скорость: " + auto.Speed);
            auto.TurnOnRadio(false);
            stream.Close();

            // Задержка.
            Console.ReadKey();
        }
    }
}
