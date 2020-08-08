using System;

/// <summary>
/// Анонимные типы
/// Анонимные типы. (Слабая ссылка)
/// </summary>
namespace _004_Anonymous
{
    class Program
    {
        static void Main()
        {
            // Вызив метод Method на экземпляре класса MyClass в анонимном типе
            new
            {
                My = new MyClass { MyProperty = 1 }

            }.My.Method();

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Автосвойство MyProperty типа int
        /// </summary>
        public int MyProperty { get; set; }

        /// <summary>
        /// Метод Method - для вывода значения автосвойства MyProperty
        /// </summary>
        public void Method()
        {
            Console.WriteLine("Field value is {0}", MyProperty);
        }
    }
}
