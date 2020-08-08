using Attribute;
using System;
using System.Reflection;

/// <summary>
/// Атрибуты
/// </summary>
namespace _010_Attributes
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            MyClass.Method();

            /*******************************/

            // 1) Получаем тип MyClass
            Type type = typeof(MyClass);

            /*******************************/

            // 2) Анализ атрибутов типа.

            // Получаем все аттрибуты заданного типа MyAttribute 
            // (false - без проверки базовых классов).
            object[] attributes = type.GetCustomAttributes(false);

            foreach (MyAttribute attribute in attributes)
            {
                Console.WriteLine("Анализ типа  : Number = {0}, Date = {1}",
                    attribute.Number, attribute.Date);
            }

            Console.WriteLine(new string('-',10));
            /*******************************/

            // 3) Анализ атрибутов метода.

            // Получаем public static метод - Method.
            MethodInfo method = type.GetMethod("Method", BindingFlags.Public | BindingFlags.Static);

            // Получаем все аттрибуты заданного типа MyAttribute 
            // (false - без проверки базовых классов).
            attributes = method.GetCustomAttributes(typeof(MyAttribute), false);

            foreach (MyAttribute attribute in attributes)
            {
                Console.WriteLine("Анализ метода: Number = {0}, Date = {1}",
                    attribute.Number, attribute.Date);
            }

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Создание пользовательского класса MyClass
    /// и декорирование его пользовательским атрибутом MyAttribute
    /// </summary>
    [My("1/31/2008", Number = 1)]
    public class MyClass
    {
        [MyAttribute("2/31/2007", Number = 2)]
        [MyAttribute("1/31/2008", Number = 1)]
        public static void Method()
        {
            Console.WriteLine("MyClass.Method()\n");
        }
    }
}
