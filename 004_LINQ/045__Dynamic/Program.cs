using System;

/// <summary>
///  Динамические типы данных.
/// </summary>
namespace _045__Dynamic
{
    class Program
    {
        static void Main()
        {
            dynamic calculator = new Calculator();

            Console.WriteLine(calculator.Add(2, 3));
            Console.WriteLine(calculator.Add(2, "1"));

            // Задержка.
            Console.ReadKey();
        }
    }
    
    class Calculator
    {
        public dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
    }
}
