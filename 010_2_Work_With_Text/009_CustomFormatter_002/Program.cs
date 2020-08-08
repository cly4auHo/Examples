using System;
using System.Globalization;
using System.Text;

namespace _009_CustomFormatter_002
{
    class Program
    {
        static void Main()
        {
            CultureInfo my = CultureInfo.CurrentCulture;
            CultureInfo en = new CultureInfo("uk-UA");

            Complex complex = new Complex(12.3456, 1234.56);

            string stringComplex = complex.ToString("F", my);
            Console.WriteLine(stringComplex);

            stringComplex = complex.ToString("F", en);
            Console.WriteLine(stringComplex);

            ComplexTestFormatter testFormatter = new ComplexTestFormatter();
            stringComplex = String.Format(testFormatter, "{0:TEST}", complex);

            Console.WriteLine("\nОтладочный вывод:\n{0}", stringComplex);

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 1.-й Вариант
    /// </summary>
    public struct Complex : IFormattable
    {
        private double real;
        private double imaginary;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public double Real
        {
            get { return real; }
        }

        public double Imaginary
        {
            get { return imaginary; }
        }

        // Реализация IFormattable 
        public string ToString(string format, IFormatProvider formatProvider)
        {
            var builder = new StringBuilder();

            builder.Append(" ( ");
            builder.Append(real.ToString(format, formatProvider));
            builder.Append(" : ");
            builder.Append(imaginary.ToString(format, formatProvider));
            builder.Append(" ) ");

            return builder.ToString();
        }
    }

    /// <summary>
    /// 2. Расширение структуры Complex
    /// </summary>
    public class ComplexTestFormatter : ICustomFormatter, IFormatProvider
    {
        /// <summary>
        /// // Реализация IFormatProvider. Неявно вызывается методом String.Format(...
        /// </summary>
        public object GetFormat(Type formatType)
        {
            return formatType == typeof(ICustomFormatter)
                ? this
                : CultureInfo.CurrentCulture.GetFormat(formatType);
        }

        /// <summary>
        /// Реализация ICustomFormatter 
        /// </summary>
        public string Format(string format, object argument, IFormatProvider formatProvider)
        {
            if (argument is Complex && format == "TEST")
            {
                var complex = (Complex)argument;

                // Сгенерировать отладочный вывод для данного объекта 
                var builder = new StringBuilder();

                builder.Append(argument.GetType() + "\n");
                builder.AppendFormat("^действительная:\t{0}\n", complex.Real);
                builder.AppendFormat("^мнимая:\t\t{0}\n", complex.Imaginary);

                return builder.ToString();
            }
            else
            {
                var formattable = argument as IFormattable;

                return formattable != null
                    ? formattable.ToString(format, formatProvider)
                    : argument.ToString();
            }
        }
    }
}
