using AttributeWork;
using System;

/// <summary>
/// Атрибуты
/// </summary>
namespace _003_Attributes
{
    class Program
    {
        static void Main()
        {
            Type type = typeof(DerivedClass);

            // При переопределении в производном классе возвращает массив настраиваемых атрибутов,
            // применяемых к этому элементу и определяемых параметром System.Type.
            object[] attributes = type.GetCustomAttributes(typeof(MyAttribute), true);

            foreach (MyAttribute attribute in attributes)
            {
                Console.WriteLine("{0}, {1}", attribute.Text, attribute.Data);
                attribute.Method();
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    [My("XXXXX", "YYYYY")]
    class BaseClass
    {
    }

    [My("First", "31/01/2008")]
    [My("Second", "31/01/2009")]
    class DerivedClass : BaseClass
    {
    }
}
