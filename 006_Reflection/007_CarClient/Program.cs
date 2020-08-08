using _006_Car_Library;
using System;

namespace _007_CarClient
{
    class Program
    {
        static void Main()
        {
            // Создаем автомобиль спортивной модели.
            SportsCar sportcar = new SportsCar("Jaguar", 240, 40);
            sportcar.Acceleration();

            // Создаем мини-вэн.
            MiniVan minivan = new MiniVan();
            minivan.Acceleration();

            // Задержка.
            Console.ReadKey();
        }
    }
}
