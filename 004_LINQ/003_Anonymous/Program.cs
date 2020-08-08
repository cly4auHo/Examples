using System;

/// <summary>
/// Анонимные типы
/// Анонимные типы. (Сильная ссылка)
/// </summary>
namespace _003_Anonymous
{
    class Program
    {
        static void Main()
        {
            //anonymousType - объект анонимного типа, у которого определено свойство My, 
            //которое фактически хранит ссылку на эеземпляр класса MyClass
            var anonymousType = new { My = new MyClass() };

            //присваевам значение свойству MyProperty экземпляра класса MyClass
            anonymousType.My.MyProperty = 1;

            //вызиваем метод Method экземпляра класса MyClass
            anonymousType.My.Method();

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
