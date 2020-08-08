/// <summary>
/// Пространства имен.
/// Видимость во вложенных пространствах имен, при отсутствии импорта.
/// </summary>
namespace _007_Namespaces
{
    class Program
    {
        static void Main()
        {
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
                MyClassC myC = new MyClassC();
            }
        }

        class MyClassB
        {
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
            //MyClassC myC = new MyClassC();
        }
    }

    class MyClassA
    {
        MyClassA myA = new MyClassA();
        //MyClassB myB = new MyClassB(); 
        //MyClassC myC = new MyClassC();
    }
}
