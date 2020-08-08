using System;
using System.Diagnostics;

/// <summary>
/// А
/// </summary>
namespace DebuggerDisplayAttributeNamespace
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass("test");
            Console.WriteLine(myClass.MyStringProperty);

            //Задержка
            Console.ReadKey();
        }
    }

    [DebuggerDisplayAttribute("{MyIntProperty}")]
    public class MyClass
    {
        public int MyIntProperty { get; set; }

        public string MyStringProperty { get; set; }

        public MyClass(string argument)
        {
            MyStringProperty = argument;
            MyIntProperty = 100;
        }
    }
}
