using System;

/// <summary>
/// Обобщение
/// Ограничения параметров типа 
/// </summary>
namespace _016_Generics
{
    class Program
    {
        static void Main()
        {
            ReferenceType<string> referenceType1 = new ReferenceType<string>();
            //Ошибка уровня компилации, так как int - структурный тип.
            //ReferenceType<int> referenceType2 = new ReferenceType<int>();

            ValueTypes<int> valueTypes1 = new ValueTypes<int>();
            //Ошибка уровня компилации, так как string - ссылочный тип.
            //ValueTypes<string> valueTypes1 = new ValueTypes<string>();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    ///  Класс ReferenceType
    ///  Ограничение where T : class  -   
    ///  Аргумент типа должен иметь ссылочный тип, 
    ///  это также распространяется на тип любого класса, интерфейса, делегата или массива.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ReferenceType<T> where T : class
    {
        public T variable;
    }

    /// <summary>
    /// Класс ValueTypes
    /// Аргумент типа должен иметь тип значения. 
    /// Допускается указание любого типа значения, кроме Nullable.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ValueTypes<T> where T : struct
    {
        public T variable;
    }
}
