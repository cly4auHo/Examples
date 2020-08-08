using System;

/// <summary>
/// Ковариантность обобщений.
/// Ковариантность: позволяет использовать более конкретный тип, чем заданный изначально.
/// Обобщенные интерфейсы могут быть ковариантными, если к универсальному параметру 
/// применяется ключевое слово out. 
/// </summary>
namespace _009_Generics
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass =  new DerivedClass();

            IContainer<BaseClass> container = new Container<DerivedClass>(derivedClass);

            Console.WriteLine(container.ToString());

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
    /// out указывает на ковариантность интерфейса.
    /// </summary>
    public interface IContainer<out T>
    {
        /// <summary>
        /// Автосвойство Element типа T
        /// </summary>
        T Element { get;}
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
