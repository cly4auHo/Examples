using _002_Type_Reflection;
using System;
using System.Reflection;

/// <summary>
/// Запись значения в private поле из примера 2
/// Предварительно в ссылках текущего проекта необходимо 
/// добавить ссылку на предыдущий пример
/// </summary>
namespace _004_Type_Reflection
{
    class Program
    {
        static void Main()
        {
            // Шаг 1 - Создаем экземпляр класса myClass
            MyClass myClass = new MyClass();
            
            // Шаг 2 Создаем экземпляр класса Type
            Type type = myClass.GetType();

            // Шаг 3 Создаем экземпляр класса FieldInfo
            FieldInfo mystring = type.GetField("mystring", 
                  BindingFlags.Instance 
                | BindingFlags.NonPublic);

            //Console.WriteLine(myClass.MyString);

            //  Шаг 4 записываем значения в private поле
            mystring.SetValue(myClass, "Привет Мир!");

            //Console.WriteLine(myClass.MyString);

            //Задержка
            Console.ReadKey();
        }
    }
}
