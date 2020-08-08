using System;

/// <summary>
/// Переопределение ToString
/// String.Format
/// </summary>
namespace _003_Strings
{
    class Program
    {
        static void Main()
        {
            // Создаем несколько переменных разных типов.
            Int32 myInt = 32;
            Double myDouble = 32.32;

            MyClass1 myClass1 = new MyClass1();
            MyClass2 myClass2 = new MyClass2();

            // Демонстрация работы метода ToString().
            // {0:x} форматирует значение как шестнадцатеричное
            Console.WriteLine("Примитивные типы:");
            string s1 =
                String.Format("myInt = {0:x} - Выводится само значение.", myInt);
            Console.WriteLine(s1);
            Console.WriteLine("myDouble = {0} - Выводится само значение.", myDouble);

            Console.WriteLine("\nПользовательские типы:");
            Console.WriteLine("my1 = {0} - Выводится полное квалифицированное имя типа.",
                myClass1.ToString());
            Console.WriteLine("my2 = {0} - Выводится предопределенная строка.",
                myClass2);

            // Задержка.
            Console.ReadKey();
        }
    }

    class MyClass1
    {
    }
    class MyClass2
    {
        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "We changed the ToString()";
        }
    }
}
