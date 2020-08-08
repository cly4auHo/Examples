using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Делегат
/// ref и out параметры метода в анонимных (лямбда) методах.
/// </summary>
namespace _008_Delegates
{
    class Program
    {
        /// <summary>
        /// Создаем класс делегата.
        /// Создаем класс-делегата с именем MyDelegate,
        /// метод, который будет сообщен с экземпляром данного класса-делегата,
        /// будет принимать два целочисленных (ref) аргумента и возвращать целочисленный аргумент (out).
        /// </summary>
        public delegate int MyDelegate(ref int a, ref int b, int c);
        static void Main()
        {
            int summand1 = 1;
            int summand2 = 2;
            int sum = 0;

            // Создаем экземпляр класса-делегата MyDelegate и сообщаем с ним анонимный метод, 
            MyDelegate myDelegate = delegate (ref int a, ref int b, int c) { a++; b++; return c = a + b; };

            // Вызов анонимного метода, сообщенного с делегатом.
            sum = myDelegate(ref summand1, ref summand2, sum);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Задержка.
            Console.ReadKey();
        }
    }
}
