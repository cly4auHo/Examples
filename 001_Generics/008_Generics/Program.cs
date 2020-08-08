using System;

/// <summary>
/// Инвариантность обобщений.
/// Инвариантность обобщений позволяет использовать только заданный тип.
/// </summary>
namespace _008_Generics
{
    class Program
    {
        static void Main()
        {
            //Создание екземпляра базового класса
            BaseClass baseClass = new BaseClass();

            IContainer<BaseClass> baseContainer = new Container<BaseClass>(baseClass);
            Console.WriteLine(baseContainer.Element.ToString());

            Console.WriteLine(new string('-',10));

            //Создание екземпляра унаследованного класса
            DerivedClass derivedClass = new DerivedClass();

            IContainer<DerivedClass> derivedContainer = new Container<DerivedClass>(derivedClass);
            Console.WriteLine(derivedContainer.Element.ToString());

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Базовый класс
    /// </summary>
    public class BaseClass { }

    /// <summary>
    /// Унаследованный класс
    /// </summary>
    public class DerivedClass : BaseClass { }

    /// <summary>
    /// Интерфейс IContainer параметризированный указателем Места Заполнения Типом - T
    /// </summary>
    public interface IContainer<T>
    {
        /// <summary>
        /// Автосвойство Element типа T
        /// </summary>
        T Element { get; set; }
    }

    /// <summary>
    ///  Класс Container, реализует интерфейс IContainer 
    /// </summary>
    public class Container<T> : IContainer<T>
    {
        /// <summary>
        /// Реализация автосвойства из интерфейса IContainer
        /// </summary>
        public T Element { get; set; }

        //Конструктор класс Container
        public Container(T element)
        {
            this.Element = element;
        }
    }
}
