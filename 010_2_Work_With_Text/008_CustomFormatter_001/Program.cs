using System;
using System.Text;
using System.Globalization;

/// <summary>
///  Создание форматированного пользовательского вывода.
/// </summary>
namespace _008_CustomFormatter_001
{
    class Program
    {
        static void Main()
        {
            CultureInfo my = CultureInfo.CurrentCulture;
            CultureInfo ua = new CultureInfo("uk-UA");

            Complex complex = new Complex(12.3456, 1234.5678);

            // F - по умолчанию = F2.
            string stringComplex = complex.ToString("F", my);
            // RU - запятая в числе.
            Console.WriteLine(stringComplex); 

            stringComplex = complex.ToString("F2", ua);
            Console.WriteLine(stringComplex); // US - точка в числе.

            Console.WriteLine("\nОтладочный вывод:\n{0:TEST}", complex);

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Структура комплексного числа
    /// </summary>
    public struct Complex : IFormattable
    {
        /// <summary>
        /// Реальная часть
        /// </summary>
        private double real;
        
        /// <summary>
        /// Мнимая часть
        /// </summary>
        private double imaginary;

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        /// <summary>
        /// Реализация IFormattable 
        /// </summary>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            var builder = new StringBuilder();

            if (format == "TEST")
            {
                // Генерация отладочного вывода для данного объекта 
                builder.Append(this.GetType() + "\n");
                builder.AppendFormat(" действительная:\t{0}\n", real);
                builder.AppendFormat(" мнимая:\t\t{0}\n", imaginary);
            }
            else
            {
                builder.Append(" ( ");
                builder.Append(real.ToString(format, formatProvider));
                builder.Append(" : ");
                builder.Append(imaginary.ToString(format, formatProvider));
                builder.Append(" ) ");
            }

            return builder.ToString();
        }
    }

}
