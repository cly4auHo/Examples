using System;
using LibraryA;

namespace _023_Namespaces_Internal
{
    class Program
    {
        static void Main()
        {
            // 1. MyPublicClass из 024_LibraryA

            MyPublicClass instanceA = new MyPublicClass();
            instanceA.PublicMethod();

            //instanceA.InternalMethod();             // Недоступен.
            //instanceA.InternalProtectedMethod();    // Недоступен.

            Console.WriteLine(new string('-', 20));


            // 2. MyClass который наследуется от MyPublicClass из  024_LibraryA

            Internal.MyClass instance = new Internal.MyClass();
            instance.PublicMethod();
            // Вызов InternalProtectedMethod().
            instance.MyMethod();
            // Недоступен.
            //instance.InternalMethod();

            Console.WriteLine(new string('-', 20));

            // 3.  MyInternalClass  - не доступен из за своего упровня защиты
            //MyInternalClass myInternalClass = new LibraryA.MyInternalClass();

            // Задержка.
            Console.ReadKey();
        }
    }
}
