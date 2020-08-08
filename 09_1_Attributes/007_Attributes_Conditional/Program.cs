#define Use

using System;
using System.Diagnostics;

/// <summary>
/// Атрибут Conditional позволяет создавать условные методы, 
/// которые вызываются только в том случае, если с помощью директивы 
/// #define определен конкретный идентификатор, а иначе метод пропускается. 
/// Следовательно, условный метод служит альтернативой условной компиляции по директиве #if.
/// Для применения атрибута Conditional в исходный код программы следует 
/// включить пространство имен System.Diagnostics.
/// </summary>
namespace _007_Attributes_Conditional
{
    class Program
    {
        static void Main()
        {
            Motorcycle motorcycle = new Motorcycle();

            motorcycle.UseMotorcycle();
            motorcycle.NoUseMotorcycle();

            Console.ReadLine();
        }
    }

    class Motorcycle
    {
        [Conditional("Use")]
        public void UseMotorcycle()
        {
            Console.WriteLine("Доступен");
        }

        [Conditional("NoUse")]
        public void NoUseMotorcycle()
        {
            Console.WriteLine("Не доступен");
        }
    }
}
