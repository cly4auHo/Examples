using System;

namespace AssertSamples
{
    public class MyClass
    {
        /// <summary>
        /// Получения квадратного корня
        /// </summary>
        public static double GetSqrt(double value)
        {
            return Math.Sqrt(value);
        }

        /// <summary>
        /// Метод для возврата приветствия
        /// </summary>
        public string SayHello(string name)
        {
            // Проверка имени на null
            if (name == null)
            {
                throw new ArgumentNullException("Parameter name cannot be null!");
            }

            return string.Concat("Hello ", name);
        }
    }
}
