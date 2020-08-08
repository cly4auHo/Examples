using System;

/// <summary>
/// Динамические типы данных. 
/// </summary>
namespace _041__Dynamic
{
    class Program
    {
        static void Main()
        {
            dynamic instance = new MyClass();

            if (false)
            {
                instance.Method(7);                  // Вызов метода.
                instance.field = instance.Property;  // Получение и установка значений полей и свойств.
                instance["one"] = instance[2];       // Получение и установка значений через индексаторы.
                dynamic variable = instance + 3;     // Вызов операторов.
                variable = instance(5, 7);           // Вызов делегатов.
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    class MyClass { }
}
