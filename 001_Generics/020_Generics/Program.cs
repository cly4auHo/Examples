using System;

/// <summary>
/// Обобщение
/// Ограничения параметров типа
/// </summary>
namespace _020_Generics
{
    class Program
    {
        static void Main()
        {
            // В качестве аргумента типа подходит Derived, т.к., он наследуется от обоих интерфейсов.
            MyClass<Derived> my1 = new MyClass<Derived>();
            //MyClass<IInterface> my1 = new MyClass<IInterface>();   // Ошибка.

            //  Аргумент типа подходит, т.к., IInterface<object> наследуется от IInterface
            MyClass<IInterface<object>> my2 = new MyClass<IInterface<object>>();

            MyClass2<Derived> my3 = new MyClass2<Derived>();
            MyClass2<Derived2> my4 = new MyClass2<Derived2>();
            MyClass2<IInterface<object>> my5 = new MyClass2<IInterface<object>>();

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Итерфейс IInterface 
    /// </summary>
    interface IInterface {}

    /// <summary>
    /// Итерфейс IInterface<U>
    /// параметризированный указателем Места Заполнения Типом - U 
    /// </summary>
    interface IInterface<U> : IInterface {}

    /// <summary>
    /// Класс Derived - реализует интерфейсы IInterface, IInterface<U>,
    /// IInterface<U> - закрыт типом object
    /// </summary>
    class Derived : IInterface, IInterface<object> {}

    /// <summary>
    ///  Класс Derived2 - реализует интерфейс IInterface<U>,
    ///  IInterface<U> - закрыт типом object
    /// </summary>
    class Derived2 : IInterface<object> {}

    // where T : IInterface, IInterface<object>  -  Аргумент типа должен являться или реализовывать указанный интерфейс.
    // Можно установить несколько ограничений интерфейса. Ограничивающий интерфейс также может быть универсальным.

    class MyClass<T> where T : IInterface, IInterface<object> {}

    class MyClass2<T> where T : IInterface<object> {}
}
