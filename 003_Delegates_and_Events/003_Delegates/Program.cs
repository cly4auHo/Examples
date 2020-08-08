using System;

/// <summary>
/// Делегат 
/// Делегаты представляют такие объекты, которые указывают на методы. То есть 
/// делегаты - это указатели на методы и с помощью делегатов мы можем вызвать данные методы.
/// </summary>
namespace _003_Delegates
{
    /// <summary>
    /// 1. Создаем класс делегата.
    /// Создаем класс-делегата с именем MyDelegate,
    /// метод, который будет сообщен с экземпляром данного класса-делегата,
    /// будет принимать один строковой аргумент и возвращать строковое значение.
    /// </summary>
    public delegate string MyDelegate(string name);
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            // 2. Создаем экземпляр делегата и сообщаем с ним метод.
            MyDelegate myDelegate = new MyDelegate(instance.Method);

            // 3. Вызываем метод сообщенный с делегатом. (3)
            string greeting = myDelegate.Invoke("Alexs");

            Console.WriteLine(greeting);

            Console.WriteLine(new string('-', 10));

            // Другой способ вызова метода сообщенного с делегатом. (3')
            greeting = myDelegate("Student");

            Console.WriteLine(greeting);

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс, метод которого будет сообщен с делегатом.
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Создаем метод, который планируем сообщить с делегатом, метод принимает
        /// один аргумент типа string и имеет возвращаемое значение типа string
        /// </summary>
        public string Method(string name)
        {
            return "Hello " + name;
        }
    }
}
