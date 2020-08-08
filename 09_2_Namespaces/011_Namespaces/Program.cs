using MyClass = MyNamespace.MyNamespace.MyClass;
using MyNamespace;
using cw = System.Console;
/// <summary>
/// Пространства имен.
/// </summary>
namespace _011_Namespaces
{
    class Program
    {
        static void Main()
        {
            MyNamespace.MyClass myClass1 = new MyNamespace.MyClass();

            cw.WriteLine(new string('-', 10));

            MyClass myClass = new MyClass();

            //Задержка
            System.Console.ReadLine();
        }
    }
}

namespace MyNamespace
{
    class MyClass 
    {
        public MyClass()
        {
            System.Console.WriteLine("MyNamespace.MyClass");
        }
    }

    namespace MyNamespace
    {
        /// <summary>
        /// Допустимо иметь во вложенных пространствах имен, одноименные классы.
        /// </summary>
        public class MyClass 
        {
            public MyClass()
            {
                System.Console.WriteLine("MyNamespace.MyNamespace.MyClass");
            }
        }
    }
}
