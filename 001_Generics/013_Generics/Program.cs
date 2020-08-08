using System;

/// <summary>
/// Обобщение
/// Частичные классы.
/// </summary>
namespace _013_Generics
{
    class Program
    {
        static void Main()
        {
            int operand1 = 1;
            int operand2 = 2;

            MyClass<int> instance = new MyClass<int>();

            instance.Method(operand1, ref operand2);

            Console.WriteLine(operand2);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// MyClass - частичный класс
    /// параметризированный указателем Места Заполнения Типом - T 
    /// </summary>
    public partial class MyClass<T>
    {
        /// <summary>
        /// Обявление метода PartialMethod
        /// </summary>
        partial void PartialMethod<T>(T a, ref T b);
    }

    /// <summary>
    /// MyClass - частичный класс
    /// параметризированный указателем Места Заполнения Типом - T 
    /// </summary>
    public partial class MyClass<T>
    {
        /// <summary>
        ///Реализация метода PartialMethod,
        ///ref - передача параметра по ссылке 
        /// </summary>
        partial void PartialMethod<T>(T a, ref T b)
        {
            b = default(T);
            Console.WriteLine("{0}, {1}", a, b);
        }

        /// <summary>
        /// Обичный метод Method,
        /// вызивает метод PartialMethod
        /// </summary>
        public void Method(T a, ref T b)
        {
            PartialMethod(a, ref b);
        }
    }
}
