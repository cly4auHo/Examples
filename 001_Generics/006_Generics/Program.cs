using System;

/// <summary>
/// Обобщение
/// Обобщение в методах
/// </summary>
namespace _006_Generics
{
    class Program
    {
        static void Main()
        {
            // Создаем экземпляр класса MyClass 
            MyClass myClass = new MyClass();

            // На экземпляр класса myClass вызиваем метод Method<T> 
            // и в качестве параметра типа передаем тип string.
            myClass.Method<string>("myClass.Method");
           
            Console.WriteLine(new string('-', 10));

            // На экземпляр класса myClass вызиваем метод Method<T>,
            // параметра типа string, можно не указывать, так как передаем параметр типа string.
            myClass.Method("myClass.Method");

            //Задержка
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Метод Method параметризированный Указателем Места Заполнения Типа - T
        /// </summary>
        public void Method<T>(T argument)
        {
            T variable = argument;

            Console.WriteLine(variable);
            Console.WriteLine(variable.GetType());
        }
    }
}
