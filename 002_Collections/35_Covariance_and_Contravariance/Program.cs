using System;
using System.Collections.Generic;


namespace _35_Covariance_and_Contravariance
{
    class Program
    {
        static void Main()
        {
            //UPCAST типов
            Ford ford1 = new Ford();
            Car car1 = ford1;

            // Не работает с параметрами типов
            List<Ford> fords = new List<Ford>();
            // List<Car> cars = fords;
            // cars.Add(new Renault());
            // Ford ford = cars[0];

            // Интерфейс public interface IEnumerable<out T> - ковариантный 
            IEnumerable<Ford> fordList = new List<Ford>();
            IEnumerable<Car> cars = fordList;

            foreach (Car item in cars)
            {
                Console.WriteLine(item);
            }

            // Так нельзя
            //cars.Add(new Renault());
        }
    }

    public class Car{}

    public class Ford : Car{}

    public class Renault: Car { }
}
