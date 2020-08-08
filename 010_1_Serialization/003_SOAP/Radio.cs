using System;

namespace SerializableWork
{
    /// <summary>
    /// Класс Radio будет доступен для сериализации.
    /// </summary>
    [Serializable]
    public class Radio
    {
        [NonSerialized]
        private int id = 9;

        /// <summary>
        /// Метод включения/выключения радио.
        /// </summary>
        public void OnOff(bool state)
        {
            Console.WriteLine(state ? "Радио Включено." : "Радио Выключено.");
        }
    }
}
