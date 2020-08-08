using System;

/// <summary>
/// Делегат
/// Лямбда выражения и лямбда операторы.
/// </summary>
namespace _0110_Delegates
{
    class Program
    {
        // Создаем класс делегата.
        public delegate void MyDelegate();
        static void Main()
        {
            MyDelegate myDelegate;

            // Лямбда-Метод 
            myDelegate = delegate () { Console.WriteLine("Hello 1"); };
            myDelegate();

            Console.WriteLine(new string('-', 10));

            // Лямбда-Оператор.
            myDelegate += () => { Console.WriteLine("Hello 2"); };
            myDelegate();

            Console.WriteLine(new string('-', 10));

            // Лямбда-Выражение.
            myDelegate += () => Console.WriteLine("Hello 3");
            myDelegate();

            Console.WriteLine(new string('-', 10));

            myDelegate.Invoke();

            // Задержка.
            Console.ReadKey();
        }
    }
}
