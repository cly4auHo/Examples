using System;

/// <summary>
/// Рефлексия. Пример получения экземпляра Type.
/// </summary>
namespace _001_Type_Reflection
{
    class Program
    {
        static void Main()
        {
            //Создание экземпляра пользовательского класса 
            MyClass myClass = new MyClass();

            /*********************************************/
            /* Способы получения экземрляра класса Type. */
            /*********************************************/

            //1-й способ получения экземрляра класса Type
            Type typeFirstWay = myClass.GetType();

            Console.WriteLine("1-й способ: " + typeFirstWay);
            Console.WriteLine("1-й способ: " + typeFirstWay.Name);
            Console.WriteLine(new string('-', 10));

            //2-й способ получения экземрляра класса Type
            Type typeSecondtWay = Type.GetType("_001_Type_Reflection.MyClass");

            Console.WriteLine("2-й способ: " + typeSecondtWay);
            Console.WriteLine("2-й способ: " + typeSecondtWay.Name);
            Console.WriteLine(new string('-', 10));

            //3-й способ получения экземрляра класса Type
            Type typeThirdWay = typeof(MyClass);

            Console.WriteLine("3-й способ: " + typeThirdWay);
            Console.WriteLine("3-й способ: " + typeThirdWay.Name);
            Console.WriteLine(new string('-', 10));

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Создание пользовательского класса
    /// </summary>
    public class MyClass {}
}
