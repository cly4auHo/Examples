using System;

/// <summary>
/// Делегат
/// Лямбда выражения и лямбда операторы.
/// </summary>
namespace _009_Delegates
{
    class Program
    {
        /// <summary>
        /// Создаем класс делегата.
        /// Создаем класс-делегата с именем MyDelegate,
        /// метод, который будет сообщен с экземпляром данного класса-делегата,
        /// будет принимать один целочисленний аргумент и возвращать целочисленное значение.
        /// </summary>
        public delegate int MyDelegate(int argument);
        static void Main()
        {
            // Создаем переменную -myDelegate типа делегата MyDelegate
            MyDelegate myDelegate;

            // Создаем переменную - result типа int 
            int result;

            // Лямбда-Метод 
            // переменную -myDelegate сообщаем с Лямбда-Методом
            myDelegate = delegate (int x) { return x * 2; };

            // Вызов анонимного метода, сообщенного с делегатом.
            result = myDelegate(4);
            Console.WriteLine(result);
            Console.WriteLine(new string('-', 10));

            // Лямбда-Оператор.
            // переменную -myDelegate сообщаем с Лямбда-Оператором
            myDelegate = (x) => { return x * 2; };

            // Вызов анонимного метода, сообщенного с делегатом.
            result = myDelegate(4);
            Console.WriteLine(result);
            Console.WriteLine(new string('-', 10));

            // Лямбда-Выражение.
            // переменную -myDelegate сообщаем с Лямбда-Выражением
            myDelegate = x => x * 2;

            // Вызов анонимного метода, сообщенного с делегатом.
            result = myDelegate(4);

            Console.WriteLine(result);
            Console.WriteLine(new string('-', 10));

            // Задержка.
            Console.ReadKey();
        }
    }
}
