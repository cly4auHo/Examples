using System;

namespace _005_Delegates
{
    // <summary>
    /// Создаем класс делегата. (1) 
    /// метод, который будет сообщен с экземпляром данного класса-делегата, 
    /// не будет ничего принимать и не будет ничего возвращать.
    /// </summary>
    public delegate void MyDelegate();
    class Program
    {
        static void Main()
        {
            // Создаем экземпляр класса-делегата MyDelegate и сообщаем с ним анонимный метод.
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello world!"); };

            // Вызов анонимного метода, сообщенного с делегатом.
            myDelegate();

            // Задержка.
            Console.ReadKey();
        }
    }
}
