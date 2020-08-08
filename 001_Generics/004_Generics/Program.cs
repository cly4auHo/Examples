using System;
using System.Collections.Generic;

/// <summary>
/// Термин обобщение, по существу, означает параметризированный тип. 
/// Особая роль параметризированных типов состоит в том, что они позволяют создавать 
/// классы, структуры, интерфейсы, методы и делегаты, в которых обрабатываемые данные 
/// указываются в виде параметра. С помощью обобщений можно, например, создать единый класс,
/// который автоматически становится пригодным для обработки разнотипных данных. 
/// </summary>
namespace _004_Generics
{
    class Program
    {
        static void Main()
        {
            // Создаем экземпляр класса MyClass и в качестве параметра типа (тип MyClass) передаем тип int.
            MyClass<int> instance1 = new MyClass<int>();
            instance1.Method();

            // Создаем экземпляр класса MyClass и в качестве параметра типа (тип MyClass) передаем тип long.
            MyClass<long> instance2 = new MyClass<long>();
            instance2.Method();

            // Создаем экземпляр класса MyClass и в качестве параметра типа (тип MyClass) передаем тип string.
            MyClass<string> instance3 = new MyClass<string>();
            instance3.field = "ABC";
            instance3.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// создаем класс с именем MyClass, параметризированный Указателем Места Заполнения Типом - T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyClass<T>
    {
        /// <summary>
        /// Поле field
        /// </summary>
        public T field;

        /// <summary>
        /// Метод для отображения информации о типе
        /// </summary>
        public void Method()
        {
            //GetType - возвращает текущий Type.
            Console.WriteLine(field.GetType());
        }
    }
}
