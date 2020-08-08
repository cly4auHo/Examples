using System;

/// <summary>
/// Пространство имен Attribute
/// </summary>
namespace Attribute
{
    /// <summary>
    /// Создание пользовательского атрибута
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class MyAttribute : System.Attribute
    {
        private readonly string date;
        public string Date
        {
            get { return date; }
        }

        /// <summary>
        /// Конструктор класса MyAttribute
        /// </summary>
        /// <param name="date"></param>
        public MyAttribute(string date)
        {
            this.date = date;
        }

        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}