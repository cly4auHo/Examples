using System;
using System.Globalization;

/// <summary>
/// Использование интерфейса IFormattable.
/// IFormattable - Предоставляет функциональность для форматирования 
/// значения объекта в строковое представление.
/// один метод 
/// string ToString(string format, IFormatProvider formatProvider);
/// </summary>
namespace _004_IFormattable
{
    class Program
    {
        static void Main()
        {
            Temperature temperature = new Temperature(20); // 20°C

            Console.WriteLine("Temperature [default]     = {0}", temperature);
            Console.WriteLine("Temperature [Fahrenheit]  = {0:K}", temperature);
            Console.WriteLine("Temperature [CultureInfo] = {0}",
                temperature.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Temperature [CultureInfo] = {0}",
                temperature.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU")));

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс Temperature
    /// </summary>
    public class Temperature : IFormattable
    {
        private decimal temperature;

        /// <summary>
        /// Конструктор класса Temperature
        /// </summary>
        /// <param name="temperature"></param>
        public Temperature(decimal temperature)
        {
            //Проверка
            if (temperature < -273.15m)
            {
                // По шкале Цельсия абсолютному нулю соответствует температура −273,15 °C
                throw new ArgumentOutOfRangeException(
                    String.Format("{0} is less than absolute zero.", temperature));
            }

            this.temperature = temperature;
        }

        /// <summary>
        /// Цельсий
        /// </summary>
        public decimal Celsius
        {
            get { return temperature; }
        }

        /// <summary>
        /// Фаренгейт
        /// </summary>
        public decimal Fahrenheit
        {
            // Перевод Цельсия в Фаренгейт.
            get { return temperature * 9 / 5 + 32; }
        }

        /// <summary>
        /// Кельвин
        /// </summary>
        public decimal Kelvin
        {
            // Перевод Цельсия в Кельвин.
            get { return temperature + 273.15m; }
        }

        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            // CultureInfo - public class CultureInfo : ICloneable, IFormatProvider
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Реализация IFormattable.
        /// </summary>
        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format))
            {
                format = "G";
            }

            if (provider == null)
            {
                provider = CultureInfo.CurrentCulture;
            }

            // ToUpperInvariant - Возвращает копию этого объекта System.String, 
            // преобразованного в верхний регистр 
            switch (format.ToUpperInvariant())
            {
                case "G":
                case "C":
                    // F2 - формат вывода вещественного числа (2 знака после запятой).
                    return temperature.ToString("F2", provider) + " °C";
                case "F":
                    return Fahrenheit.ToString("F2", provider) + " °F";
                case "K":
                    return Kelvin.ToString("F2", provider) + " K";
                default:
                    throw new FormatException(
                        String.Format("The {0} format string is not supported.", format));
            }
        }
    }
}
