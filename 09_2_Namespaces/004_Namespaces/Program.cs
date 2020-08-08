using NamespaceA.NamespaceB.NamespaceC;
/// <summary>
///  Пространства имен.
///  Создание пространства имен.
///  Вложенностьпростраиства имен
/// </summary>
namespace _004_Namespaces
{
    //using NamespaceA.NamespaceB.NamespaceC;
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();

            //Задержка
            System.Console.ReadKey();
        }
    }
}

namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClass
            {
                public MyClass()
                {
                    System.Console.WriteLine(this.GetType().Name);
                    System.Console.WriteLine(this.GetType());
                }
            }
        }
    }
}
