/// <summary>
/// Пространства имен.
/// Повторное создание вложенного пространства имен
/// </summary>
namespace _017_Namespaces
{
    using NamespaceA.NamespaceB.NamespaceC;
    class Program
    {
        static void Main()
        {
            MyClassC myC = new MyClassC();
            MyClassC2 myC2 = new MyClassC2();
        }
    }
}

namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClassC { }
        }
        class MyClassB { }
    }
    class MyClassA { }
}

/// <summary>
/// Повторное создание вложенного пространства имен.
/// </summary>
namespace NamespaceA.NamespaceB.NamespaceC
{
    class MyClassC2
    {
        MyClassA myClassA = new MyClassA();
        MyClassB myClassB = new MyClassB();
        MyClassC myClassC = new MyClassC();
    }
}
