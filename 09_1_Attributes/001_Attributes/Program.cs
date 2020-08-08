using Attributes;
using System;

/// <summary>
/// 
/// </summary>
namespace _001_Attributes
{
    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
            MyClass.Method();

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Создание пользовательского класса MyClass
    /// и декорирование его пользовательским атрибутом MyAttribute
    /// </summary>
    [ MyAttribute ("1/31/2008", Number = 1)]
    public class MyClass
    {
        [MyAttribute("2/31/2007", Number = 2)]
        public static void Method()
        {
            Console.WriteLine("MyClass.Method()");
        }
    }
}
