using System;

/// <summary>
/// Делегат
/// Анонимные (лямбда) методы в делегатах.
/// С делегатами тесно связаны анонимные методы. 
/// Анонимные методы используются для создания экземпляров делегатов
/// </summary>
namespace _006_Delegates
{
    class Program
    {
        /// <summary>
        /// Создаем класс делегата.
        /// Создаем класс-делегата с именем MyDelegate,
        /// метод, который будет сообщен с экземпляром данного класса-делегата,
        /// будет принимать два целочисленных аргумента и возвращать целочисленный аргумент.
        /// </summary>
        public delegate int MyDelegate(int a, int b);
        static void Main()
        {
            int summand1 = 1;
            int summand2 = 2;
            int sum = 0;

            // Создаем экземпляр класса-делегата MyDelegate и сообщаем с ним анонимный метод, 
            // который принимает два целочисленных аргумента и возвращает их сумму
            MyDelegate myDelegate = delegate (int a, int b) { return a + b; };

            // Вызов анонимного метода, сообщенного с делегатом, в качестве аргументов 
            // передаем аргументы summand1 и summand2
            sum = myDelegate(summand1, summand2);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Задержка.
            Console.ReadKey();
        }
    }
}
