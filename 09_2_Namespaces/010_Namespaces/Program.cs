using MyNamespace;

/// <summary>
/// Пространства имен.
/// Допускается создание нескольких пространств имен с одним именем. 
/// Несколько одноименных пространств имен, объединяются в одно пространство имен.
/// </summary>
namespace _010_Namespaces
{
    class Program
    {
        static void Main()
        {
            MyClassA myClassA = new MyClassA();
            MyClassB myClassB = new MyClassB();
            MyClassC myClassC = new MyClassC();

            // Задержка
            System.Console.ReadKey();
        }
    }
}

namespace MyNamespace
{
    class MyClassA 
    {
        public MyClassA()
        {
            System.Console.WriteLine("MyClassA");
        }
    }

    class MyClassB
    {
        public MyClassB()
        {
            System.Console.WriteLine("MyClassB");
        }
    }
}

namespace MyNamespace
{
    /// <summary>
    /// Недопустимо иметь в одноименных пространствах имен, одноименные типы.
    /// </summary>
    /// class MyClassA { }  // Ошибка.

    class MyClassC
    {
        public MyClassC()
        {
            System.Console.WriteLine("MyClassC");
        }
    }
}
