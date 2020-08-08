using System;
using System.Collections.Generic;

/// <summary>
/// Обобщение 
/// Использование нескольких универсальных параметров в классе
/// </summary>
namespace _005_Generics
{
    class Program
    {
        static void Main()
        {
            // Создаем экземпляр класса MyClass и в качестве параметров типа передаем тип int и int.
            MyClass<int, int> myClass_int = new MyClass<int, int>(1, 2);
            //Выводим информацио на консоль
            Console.WriteLine(myClass_int.Field1);
            Console.WriteLine(myClass_int.Field2);

            Console.WriteLine(new string('-', 10));

            // Создаем экземпляр класса MyClass и в качестве параметров типа передаем тип string и string.
            MyClass<string, string> myClass_string = new MyClass<string, string>("one", "two");
            //Выводим информацио на консоль
            Console.WriteLine(myClass_string.Field1);
            Console.WriteLine(myClass_string.Field2);

            Console.WriteLine(new string('-', 10));

            // Создаем экземпляр класса MyClass и в качестве параметров типа передаем тип string и string.
            MyClass<string, int> myClass_string_int = new MyClass<string, int>("one", 2);
            //Выводим информацио на консоль
            Console.WriteLine(myClass_string_int.Field1);
            Console.WriteLine(myClass_string_int.Field2);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass<Type1, Type2>
    {
        /// <summary>
        /// Поле field1 класс MyClass 
        /// </summary>
        private Type1 field1;

        /// <summary>
        /// Поле field2 класс MyClass 
        /// </summary>
        private Type2 field2;

        /// <summary>
        /// Конструктор класса MyClass
        /// </summary>
        public MyClass(Type1 argument1, Type2 argument2)
        {
            this.field1 = argument1;
            this.field2 = argument2;
        }

        /// <summary>
        /// Свойство Field1, предоставляет доступ к полю field1
        /// </summary>
        public Type1 Field1 
        {
            get { return field1; }
            set { field1 = value; }
        }

        /// <summary>
        /// Свойство Field2, предоставляет доступ к полю field1
        /// </summary>
        public Type2 Field2
        {
            get { return field2; }
            set { field2 = value; }
        }
    }
}
