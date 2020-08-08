using System;

/// <summary>
/// Обобщение
/// Ограничения параметров типа 
/// </summary>
namespace _017_Generics
{
    class Program
    {
        static void Main()
        {
            MyClass<UserClass> MyClass = new MyClass<UserClass>();
            
            MyClass.instance.MyIntProperty = 1;
            MyClass.instance.MyStringProperty = "Hello World!";

            MyClass.GetValues();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// where T : new()  -  Аргумент типа должен иметь открытый конструктор без параметров.
    /// </summary>
    class MyClass<T> where T : new()
    {
        public T instance = new T();

        public void GetValues()
        {
            Console.WriteLine(instance.ToString());
        }
    }

    class UserClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", MyIntProperty, MyStringProperty);
        }
    }
}
