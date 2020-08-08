using System;

/// <summary>
/// Обобщение
/// Ограничения параметров типа 
/// </summary>
namespace _018_Generics
{
    class Program
    {
        static void Main()
        {
            MyClass<Base> instance1 = new MyClass<Base>();

            MyClass<Derived> instance2 = new MyClass<Derived>();

            // Ошибка уровня компиляции, так как string - не являеться 
            //базовым или производным от Base класса.
            //MyClass<string> instance3 = new MyClass<string>();    

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Базовый класс - Base
    /// </summary>
    class Base { }

    /// <summary>
    /// Унаследованный класс - Derived, от базового класса Base
    /// </summary>
    class Derived : Base { }

    /// <summary>
    ///  where T : Base -  Аргумент типа должен являться или быть производным от указанного базового класса.
    /// </summary>
    class MyClass<T> where T : Base{}
}
