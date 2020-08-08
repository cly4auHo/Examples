using System;


/// <summary>
/// Анонимные типы
/// Лямбда-Выражение в анонимных типах
/// </summary>
namespace _005_Anonymous
{
    class Program
    {
        /// <summary>
        /// Создаем класс-делегата с именем MyDelegate,
        /// метод, который будет сообщен с экземпляром данного класса-делегата,
        /// который будет принимать один строковой аргумент и ничего не буте возвращать.
        /// </summary>
        delegate void MyDelegate(string @string);
        static void Main()
        {
            var instance = new
            {
                // MyDel - переменную делегата типа MyDelegate
                // переменную -myDelegate сообщаем с Лямбда-Выражением
                MyDelegate = new MyDelegate((string @string) => Console.WriteLine(@string))
            };

            // Вызываем метод сообщенный с делегатом с помощью Invoke
            instance.MyDelegate.Invoke("Hello world!");

            // или 
            // Вызываем метод сообщенный с делегатом
            instance.MyDelegate("Hello world!");

            // Задержка.
            Console.ReadKey();
        }
    }
}
