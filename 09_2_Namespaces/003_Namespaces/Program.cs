using NamespaceA;

/// <summary>
/// Пространства имен.
/// </summary>
namespace _003_Namespaces
{
    class Program
    {
        static void Main()
        {
            MyClass myClass1 = new MyClass();
            //или 
            NamespaceA.MyClass myClass2 = new NamespaceA.MyClass();

            //Задержка
            System.Console.ReadKey();
        }
    }
}
