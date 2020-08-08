using System;

namespace _010_CarLibrary
{
    public class SportsCar : Car
    {
        public SportsCar() { }

        public SportsCar(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {
        }

        public override void Acceleration()
        {
            Console.WriteLine("SPORTCAR:  Быстрая скорость!");
        }
    }
}
