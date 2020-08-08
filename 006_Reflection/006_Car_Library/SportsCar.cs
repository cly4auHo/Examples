using System;

namespace _006_Car_Library
{
    /// <summary>
    /// 
    /// </summary>
    public class SportsCar : Car
    {
        /// <summary>
        /// 
        /// </summary>
        public SportsCar() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="maxSpeed"></param>
        /// <param name="currentSpeed"></param>
        public SportsCar(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Acceleration()
        {
            Console.WriteLine("SPORTCAR:  Быстрая скорость!");
        }
    }
}
