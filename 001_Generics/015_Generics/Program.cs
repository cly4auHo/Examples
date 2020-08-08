using System;

/// <summary>
/// Обобщение
/// Ограненичение по пременению операций (+, -, *, /).
/// </summary>
namespace _015_Generics
{
    class Program
    {
        static void Main()
        {
            //Екземпляр класса MyClass<T> закрытий string
            MyClass<string> myClassString = new MyClass<string>();

            //Екземпляр класса MyClass<T> закрытий int
            MyClass<int> myClassint = new MyClass<int>();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// параметризированный указателем Места Заполнения Типом - T 
    /// </summary>
    class MyClass<T>
    {
        /// <summary>
        /// Метод для сложения двух аргументов.
        /// </summary>
        public void Add(T operand1, T operand2)
        {
            //Невозможно применят операцию сложения к обобщениям.
            //Console.WriteLine(operand1 + operand2);
        }

        /// <summary>
        /// Метод для вычитания двух аргументов.
        /// </summary>
        public void Subtraction(T operand1, T operand2)
        {
            //Невозможно применят операцию вычитания к обобщениям.
            //Console.WriteLine(operand1 + operand2);
        }
    }
}
