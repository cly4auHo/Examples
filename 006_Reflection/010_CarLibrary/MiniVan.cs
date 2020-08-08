using System;

namespace _010_CarLibrary
{
    public class MiniVan : Car
    {
        public MiniVan() { }

        public MiniVan(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {
        }

        public override void Acceleration()
        {
            // Мини-вэны разгоняются плохо.
            state = EngineState.EngineDead;
            Console.WriteLine("MINIVAN:  Двигатель сгорел!");
        }
    }
}
