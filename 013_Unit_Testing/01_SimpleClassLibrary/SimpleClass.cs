using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SimpleClassLibrary
{
    public class SimpleClass
    {
        /// <summary>
        /// Метод для сложения двух чисел
        /// </summary>
        public int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Метод для деления двух чисел
        /// </summary>
        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}
