using System;

/// <summary>
///  Контравариантность обобщений.
///  Контравариантность: позволяет использовать более универсальный тип, чем заданный изначально.
///  Для создания контравариантного интерфейса надо использовать ключевое слово in.
/// </summary>
namespace _010_Generics
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();

            IContainer<DerivedClass> container = new Container<BaseClass>(derivedClass);

            Console.WriteLine(container.ToString());

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Базовый класс
    /// </summary>
    public abstract class BaseClass { }

    /// <summary>
    /// Унаследованный класс
    /// </summary>
    public class DerivedClass : BaseClass { }

    /// <summary>
    /// Интерфейс IContainer параметризированный указателем Места Заполнения Типом - T, 
    /// in указывает на контравариантность интерфейса.
    /// </summary>
    public interface IContainer<in T>
    {
        /// <summary>
        /// Автосвойство Element типа T
        /// </summary>
        T Element { set; }
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
