using _002_Type_Reflection;
using System;
using System.Reflection;

/// <summary>
/// Вызов private метода из предыдущего примера
/// Предварительно в ссылках текущего проекта необходимо 
/// добавить ссылку на предыдущий пример
/// </summary>
namespace _003_Type_Reflection
{
    class Program
    {
        static void Main()
        {
            // MethodC - класса MyClass - private
            // принимает два аргумента
            // private void MethodC(string str, string str2)

            //Шаг 1 - Создаем экземпляр класса myClass
            MyClass myClass = new MyClass();
            
            //Шаг 2 Создаем экземпляр класса Type
            Type type = myClass.GetType();

            //Шаг 3 Создаем экземпляр класса MethodInfo
            MethodInfo methodC = type.GetMethod("MethodC", 
                  BindingFlags.Instance 
                | BindingFlags.NonPublic);

            //Шаг 4 Вызов private метода MethodC класса myClass
            methodC.Invoke(myClass, 
                new object[] { "Hello", " world!" });

            //Задержка
            Console.ReadKey();
        }
    }
}
