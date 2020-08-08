using NamespaceA;
using NamespaceA.NamespaceB;
using NamespaceA.NamespaceB.NamespaceC;

/// <summary>
/// Пространства имен.
/// Распространенные ошибки самоассоциации после первой попытки создания экземпляра класса.
/// </summary>
namespace _009_Namespaces
{
    class Program
    {
        static void Main()
        {
            MyClassA myClassA = new MyClassA();
            MyClassB myClassB = new MyClassB();
            MyClassC myClassC = new MyClassC();
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
                MyClassA myA = new MyClassA(); // StackOverflowException
                MyClassB myB = new MyClassB(); // StackOverflowException
                MyClassC myC = new MyClassC(); // StackOverflowException
            }
        }

        class MyClassB
        {
            MyClassA myA = new MyClassA(); // StackOverflowException
            MyClassB myB = new MyClassB(); // StackOverflowException
            MyClassC myC = new MyClassC();
        }
    }

    class MyClassA
    {
        MyClassA myA = new MyClassA(); // StackOverflowException
        MyClassB myB = new MyClassB(); // StackOverflowException
        MyClassC myC = new MyClassC();
    }
}

