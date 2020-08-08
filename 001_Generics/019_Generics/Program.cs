using System;

/// <summary>
///  Обобщение
/// Ограничения параметров типа
/// </summary>
namespace _019_Generics
{
    class Program
    {
        static void Main()
        {
            // В качестве аргумента типа подходит Derived, т.к., он наследуется от обоих интерфейсов.
            MyClass<Derived> my1 = new MyClass<Derived>();
            //MyClass<IInterface> my1 = new MyClass<IInterface>();   // Ошибка.
           
            MyClass2<IInterface> my2 = new MyClass2<IInterface>();
            MyClass2<Derived> my3 = new MyClass2<Derived>();

            MyClass3<IInterface<object>> my4 = new MyClass3<IInterface<object>>();
            MyClass3<Derived> my5 = new MyClass3<Derived>();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Итерфейс IInterface 
    /// </summary>
    interface IInterface { }

    /// <summary>
    /// Итерфейс IInterface<U>
    /// параметризированный указателем Места Заполнения Типом - U 
    /// </summary>
    interface IInterface<U> { }

    /// <summary>
    /// Класс Derived - реализует интерфейсы IInterface, IInterface<U>,
    /// IInterface<U> - закрыт типом object
    /// </summary>
    class Derived : IInterface, IInterface<object> { }

    /// <summary>
    /// where T : IInterface, IInterface<object>  -  Аргумент типа должен являться или реализовывать указанный интерфейс.
    /// Можно установить несколько ограничений интерфейса.
    /// Ограничивающий интерфейс также может быть универсальным.
    /// </summary>
    class MyClass<T> where T : IInterface, IInterface<object> {}

    class MyClass2<T> where T : IInterface { }

    class MyClass3<T> where T : IInterface<object> { }
}
