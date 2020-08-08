using MyNamespace.NamespaceA;
using MyNamespace.NamespaceB;

/// <summary>
/// Пространства имен.
/// Два пространства имен одного уровня вложенности, не предоставляют доступа одно другому, к своим стереотипам, без импорта.
/// </summary>
namespace _013_Namespaces
{
    class Program
    {
        static void Main()
        {
            MyClassA myClassA = new MyClassA();
            MyClassB myClassB = new MyClassB();
        }
    }
}

namespace MyNamespace
{
    namespace NamespaceA
    {
        class MyClassA
        {
            public MyClassA()
            {
                System.Console.WriteLine("MyNamespace.NamespaceA.MyClassA");
            }
            // Ошибка.
            //MyClassB my = new MyClassB();

            public NamespaceB.MyClassB myClassB = new NamespaceB.MyClassB();
        }
    }

    namespace NamespaceB
    {
        class MyClassB
        {
            public MyClassB()
            {
                System.Console.WriteLine("MyNamespace.NamespaceA.MyClassB");
            }
            // Ошибка.
            //MyClassA my = new MyClassA();

            public NamespaceA.MyClassA myClassA = new NamespaceA.MyClassA();
        }
    }
}
