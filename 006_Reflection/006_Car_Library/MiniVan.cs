using System;

namespace _006_Car_Library
{
    /// <summary>
    /// Класс MiniVan - наследуем от базового класса Car
    /// </summary>
    public class MiniVan : Car
    {
        /// <summary>
        /// Конструктор класса MiniVan
        /// </summary>
        public MiniVan() { }

        /// <summary>
        ///  Конструктор класса MiniVan с параметрами 
        /// </summary>
        /// <param name="name">Имя водителя</param>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="currentSpeed">Текущая скорость</param>
        public MiniVan(string name, short maxSpeed, short currentSpeed)
           : base(name, maxSpeed, currentSpeed) /*Вызов конструктора бащового класса*/
        {
        }

        /// <summary>
        /// Реализация abstract метода из класса Car
        /// </summary>
        public override void Acceleration()
        {
            state = EngineState.EngineDead;

            Console.WriteLine("MINIVAN:  Двигатель сгорел!");
        }
    }
}
