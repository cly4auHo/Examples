using System;

/// <summary>
/// Делегат
/// Комбинированные (групповые) делегаты.
/// </summary>
namespace _004_Delegates
{
    class Program
    {
        /// <summary>
        /// Создаем класс делегата. (1) 
        /// Для объявления делегата используется ключевое слово delegate,
        /// после которого идет возвращаемый тип, название и параметры.
        /// Класс-делегата с именем MyDelegate,
        /// метод, который будет сообщен с экземпляром данного класса-делегата, 
        /// не будет ничего принимать и не будет ничего возвращать.
        /// </summary>
        public delegate void MyDelegate();
        static void Main()
        {
            // Создаем переменную делегата типа MyDelegate.
            MyDelegate myDelegate = null;

            // Присваиваем переменной myDelegate1 адрес метода Method1
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            myDelegate1 += Method2;
            // Присваиваем переменной myDelegate2 адрес метода Method2
            MyDelegate myDelegate2 = new MyDelegate(Method2);

            // Присваиваем переменной myDelegate3 адрес метода Method3
            MyDelegate myDelegate3 = new MyDelegate(Method3);

            // Комбинируем делегаты (Объединяем делегатов).
            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

            // Вызываем методы сообщенные с делегатом.myDelegate 
            //(вызываются все методы собщенные с делегатом)
            // При вызове делегата все методы последовательно вызываются.
            myDelegate.Invoke();

            Console.WriteLine(new string('-', 10));

            // Другой способ вызова методов сообщенных с делегатом
            myDelegate();

            Console.WriteLine(new string('-', 10));

            /*Подобным образом мы можем удалять методы из делегата*/

            // Создаем переменную делегата с именем myDelegate4 типа MyDelegate.
            MyDelegate myDelegate4 = null;
            // удаляем метод myDelegate1
            // при удалении методов из делегата фактически будет создаватья новый делегат, 
            // который в списке вызова методов будет содержать на один метод меньше.
            myDelegate4 = myDelegate - myDelegate1;

            // Вызова методов сообщенных с делегатом
            myDelegate4.Invoke();

            Console.WriteLine(new string('-', 10));

            // Создаем переменную делегата с именем myDelegate5 типа MyDelegate.
            MyDelegate myDelegate5;
            // удаляем метод myDelegate2
            myDelegate5 = myDelegate - myDelegate2;

            // Вызова методов сообщенных с делегатом
            myDelegate5.Invoke();

            // MyDelegate myDelegate6;

            //Попытка использование переменной которой не присвоено значение
            //myDelegate6.Invoke();

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Создаем 1- й метод, который планируем сообщить с делегатом.
        /// </summary>
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        /// <summary>
        /// Создаем 2- й метод, который планируем сообщить с делегатом.
        /// </summary>
        public static void Method2()
        {
            Console.WriteLine("Method2");
        }

        /// <summary>
        /// Создаем 3- й метод, который планируем сообщить с делегатом.
        /// </summary>
        public static void Method3()
        {
            Console.WriteLine("Method3");
        }
    }
}
