
/// <summary>
/// Пространства имен.
/// </summary>
namespace _012_Namespaces
{
    using MyNamespace;
    using MyNamespace.MyNamespace;
    class Program
    {
        static void Main()
        {
            // Если несколько импортируемых пространств имен содержат одноименные классы, 
            // то создание экземпляра требует полной квалификации имени класса.

            // Ошибка.
            // MyClass my = new MyClass(); 

            MyNamespace.MyClass myClass1 = new MyNamespace.MyClass();
            MyNamespace.MyNamespace.MyClass myClass2 = new MyNamespace.MyNamespace.MyClass();
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
