using System;

namespace SerializableWork
{
    /// <summary>
    /// Класс Mersedes наследуется от класса Car
    /// Класс Mersedes будет доступен для сериализации. 
    /// </summary>
    [Serializable]
    public class Mersedes : Car
    {
        /// <summary>
        /// Поле типа Mode 
        /// Два режима работы - Спорт и Люкс.
        /// </summary>
        protected Mode mode;

        /// <summary>
        /// Констуктор класса Mersedes
        /// </summary>
        public Mersedes(string name, int speed, Mode mode)
            : base(name, speed)
        {
            this.mode = mode;
        }

        /// <summary>
        /// Установить режим SetMode
        /// </summary>
        public void SetMode(Mode mode)
        {
            this.mode = mode;
            Console.WriteLine(this.mode);
        }

        /// <summary>
        /// Отобразить режим
        /// </summary>
        public void ShowMode()
        {
            Console.WriteLine(this.mode);
        }
    }
}