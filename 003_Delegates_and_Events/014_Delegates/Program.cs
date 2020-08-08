using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Делегат
/// Техника предположение делегата
/// </summary>
namespace _014_Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            // MyDelegate myDelegate = new MyDelegate(MyClass.Method);

            // Предположение делегата. (Не нужно указывать new MyDelegate())
            MyDelegate myDelegate = MyClass.Method;
            myDelegate();

            // Delay.
            Console.ReadKey();
        }
    }

    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Строку вывел метод сообщенный с делегатом.");
        }
    }
}
