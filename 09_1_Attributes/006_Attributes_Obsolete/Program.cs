using System;

/// <summary>
/// Атрибуты
/// Атрибут Obsolete (сокращенное наименование класса System.ObsoleteAttribute) 
/// позволяет пометить элемент программы как устаревший. Ниже приведена общая форма этого атрибута:
/// </summary>
namespace _006_Attributes_Obsolete
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass("String", 150);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    [Obsolete("Устаревший метод, лучше использовать что-нибудь поновее :)")]
    class MyClass
    {
        /// <summary>
        /// Автосвойство MyStringProperty 
        /// </summary>
        public string MyStringProperty { get; set; }

        /// <summary>
        /// Автосвойство MyIntProperty
        /// </summary>
        public int MyIntProperty { get; set; }

        /// <summary>
        /// Констуруктор классаMyClass
        /// </summary>
        public MyClass(string stringArgument, int intArgument)
        {
            this.MyStringProperty = stringArgument;
            this.MyIntProperty = intArgument;
        }
    }
}
