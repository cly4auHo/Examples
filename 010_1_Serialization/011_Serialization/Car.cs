using System;

namespace SerializableWork
{
    // Класс Car будет доступен для сериализации.
    [Serializable]
    public class Car
    {
        /// <summary>
        /// Скорость
        /// </summary>
        protected int speed;
        
        /// <summary>
        /// Имя
        /// </summary>
        protected string name;

        /// <summary>
        /// Поле типа полькозовательского класса Radio
        /// </summary>
        protected Radio radio;

        /// <summary>
        /// Коструктор класса
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="speed">Скорость</param>
        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
            //Создааем єкземпляр класса радио
            radio = new Radio();
        }

        /// <summary>
        /// Метод включения/выключения радио.
        /// </summary>
        public void TurnOnRadio(bool state)
        {
            this.radio.OnOff(state);
        }

        /// <summary>
        /// Свойство доступа к имени
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Свойство доступа к скорости
        /// </summary>
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
