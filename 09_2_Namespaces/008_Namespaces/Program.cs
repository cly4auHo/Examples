
/// <summary>
/// Пространства имен.
/// </summary>
namespace _008_Namespaces
{
    class Program
    {
        static void Main()
        {
            NamespaceA.MyClass myClass = new NamespaceA.MyClass();
        }
    }
}

namespace NamespaceA
{
    class MyClass
    {
        MyClass my;

        /// <summary>
        /// Конструктор класса MyClass
        /// </summary>
        public MyClass()  // StackOverflowException
        {
            System.Console.WriteLine("Constructor MyClassA");

            // Самоассоциация, после первой попытки создание экземпляра класса 
            // приводит к цикличному инстанцированию.

            my = new MyClass();
        }
    }
}
