/// <summary>
/// Пространства имен.
/// Повторное создание вложенного пространства имен
/// </summary>
namespace _018_Namespaces
{
    using NamespaceA.NamespaceB;
    class Program
    {
        static void Main()
        {
            MyClassB myClassB1 = new MyClassB();
            MyClassB2 myClassB2 = new MyClassB2();
        }
    }
}

namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClassC
            {
                MyClassA myA = new MyClassA();
                MyClassB myB = new MyClassB();
                MyClassB2 myB2 = new MyClassB2();

                class MyClassB2 { } //- из повторно созданного простанства имен
            }
        }
        class MyClassB { }
    }
    class MyClassA { }
}

/// <summary>
/// 
/// </summary>
namespace NamespaceA.NamespaceB
{
    class MyClassB2 { }
}
