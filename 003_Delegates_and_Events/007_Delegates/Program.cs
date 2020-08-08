using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Делегат
/// ref и out параметры метода 
/// Методы соответствуют делегату, если они имеют один и тот же возвращаемый тип 
/// и один и тот же набор параметров. Но при етом надо учитывать, что во внимание 
/// также принимаются модификаторы ref и out.
/// </summary>
namespace _007_Delegates
{
    class Program
    {
        /// <summary>
        /// Создаем класс делегата.
        /// Создаем класс-делегата с именем MyDelegate,
        /// метод, который будет сообщен с экземпляром данного класса-делегата,
        /// будет принимать два целочисленных (ref) аргумента и возвращать целочисленный аргумент (out).
        /// </summary>
        public delegate int MyDelegate(int a, int b, out int c);
        static void Main()
        {
            int summand1 = 1;
            int summand2 = 2;
            int sum;

            // Создаем экземпляр делегата.
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);

            // Вметод сообщенный с делегатом
            myDelegate.Invoke(summand1, summand2, out sum);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс, метод которого будет сообщен с делегатом.
    /// </summary>
    static class MyClass
    {
        /// <summary>
        /// Создаем статический метод, который планируем сообщить с делегатом.
        /// </summary>
        public static int Method(int a, int b, out int c)
        {
            return c = a + b;
        }
    }
}
