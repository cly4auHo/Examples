using NamespaceA;
using NamespaceA.NamespaceB;
using NamespaceA.NamespaceB.NamespaceC;

/// <summary>
/// Пространства имен.
/// </summary>
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

// В данном месте импорт недопустим.
// Импорт допустим или в теле namespace, или перед всеми другими пространствами имен.

//using NamespaceA;
//using NamespaceA.NamespaceB;
//using NamespaceA.NamespaceB.NamespaceC;
namespace _006_Namespaces
{
    class Program
    {
        static void Main()
        {
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
            MyClassC myC = new MyClassC();
        }
    }
}

