using System;

namespace _006_Car_Library
{
    /// <summary>
    /// Абстрактный класс Car
    /// </summary>
    public abstract class Car
    {
        /// <summary>
        /// Имя водителя 
        /// </summary>
        protected string name;

        /// <summary>
        /// Текущая скорость автомобиля
        /// </summary>
        protected short currentSpeed;

        /// <summary>
        /// Максимальная скорость автомобиля
        /// </summary>
        protected short maxSpeed;

        /// <summary>
        /// Состояние двигателя
        /// </summary>
        protected EngineState state;

        /// <summary>
        /// Свойство доступа к protected field name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Свойство доступа к protected field maxSpeed
        /// </summary>
        public short MaxSpeed
        {
            get { return maxSpeed; }
        }

        /// <summary>
        /// Свойство доступа к protected field currentSpeed
        /// </summary>
        public short CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        /// <summary>
        /// Свойство доступа к protected field state (состояние двигателя)
        /// </summary>
        public EngineState EngineState
        {
            get { return state; }
        }

        /// <summary>
        /// Конструктор класса Car
        /// </summary>
        protected Car()
        {
            //Иницилизация поля state значением -
            //двигатель исправен (жыв)
            state = EngineState.EngineAlive;
        }

        /// <summary>
        ///  Конструктор класса Car с параметрами 
        /// </summary>
        /// <param name="name">Имя водителя</param>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="currentSpeed">Текущая скорость</param>
        protected Car(string name, short maxSpeed, short currentSpeed)
        : this()/*Вызываем конструктор класса без параметров*/
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.currentSpeed = currentSpeed;
        }

        /// <summary>
        /// Абстрактный метод Acceleration - ускорение
        /// </summary>
        public abstract void Acceleration();

        /// <summary>
        /// Метод для вывода информации о водителе
        /// </summary>
        public void Driver(string name, int age)
        {
            Console.WriteLine("Имя водителя: {0}. Возраст: {1}", name, age);
        }
    }
}
