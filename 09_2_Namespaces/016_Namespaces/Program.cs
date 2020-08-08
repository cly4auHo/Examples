/// <summary>
/// Пространства имен.
/// Повторное создание вложенного пространства имен
/// </summary>
namespace _016_Namespaces
{
    using NamespaceA.NamespaceB.NamespaceC;
    class Program
    {
        static void Main()
        {
            MyClassC myClassC1 = new MyClassC();
            MyClassC2 myClassC2 = new MyClassC2();
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
    class MyClassC2 { }
}
