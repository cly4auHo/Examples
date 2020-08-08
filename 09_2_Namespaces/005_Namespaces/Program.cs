/// <summary>
///  Пространства имен. 
///  Псевдонимы типов.
/// </summary>
namespace _005_Namespaces
{
    // Создание псевдонима MyClass, для класса MyClassC из пространства имен NamespaceA.NamespaceB.NamespaceC.
    using MyClass = NamespaceA.NamespaceB.NamespaceC.MyClassC;
    using NamespaceA;
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса MyClassC из пространства имени NamespaceC 
            MyClass myClass = new MyClass();
            myClass.Method();

            System.Console.WriteLine(myClass.GetType());

            //или так

            NamespaceA.NamespaceB.NamespaceC.MyClassC myClassC = new NamespaceA.NamespaceB.NamespaceC.MyClassC();
            myClassC.Method();

            myClassC.Method();

            //Задержка
            System.Console.ReadKey();
        }
    }
}

/// <summary>
/// Пространство имен NamespaceA
/// </summary>
namespace NamespaceA
{
    /// <summary>
    /// Пространство имен NamespaceB
    /// </summary>
    namespace NamespaceB
    {
        /// <summary>
        /// Пространство имен NamespaceC
        /// </summary>
        namespace NamespaceC
        {
            /// <summary>
            /// Класс MyClassC
            /// </summary>
            class MyClassC
            {
                /// <summary>
                /// Метод Method()
                /// </summary>
                public void Method()
                {
                    System.Console.WriteLine("Hello world!");
                }
            }
        }
        /// <summary>
        /// Класс MyClassB
        /// </summary>
        class MyClassB { }
    }

    /// <summary>
    /// Класс MyClassA
    /// </summary>
    class MyClassA { }
}
