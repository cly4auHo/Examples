using System;

/// <summary>
/// Патерн прототип
/// </summary>
namespace _013_Prototype
{
    class Program
    {
        static void Main()
        {
            // Создание двух экземпляров и клонирование их.
            ConcretePrototype1 p1 = new ConcretePrototype1("1");
            ConcretePrototype1 c1 = p1.Clone() as ConcretePrototype1;
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("2");
            ConcretePrototype2 c2 = p2.Clone() as ConcretePrototype2;
            Console.WriteLine("Cloned: {0}", c2.Id);

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 1. Класс Prototype
    /// </summary>
    abstract class Prototype
    {
        // Поле.
        private string id;

        // Конструктор.
        public Prototype(string id)
        {
            this.id = id;
        }

        // Свойство.
        public string Id { get { return id; } }

        // Метод клонирования.
        public abstract Prototype Clone();
    }

    /// <summary>
    /// 2. "ConcretePrototype1"
    /// </summary>
    class ConcretePrototype1 : Prototype
    {
        // Конструктор.
        public ConcretePrototype1(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            // Глубокое копирование.
            return new ConcretePrototype1(this.Id);
        }
    }

    /// <summary>
    /// 2. "ConcretePrototype2"
    /// </summary>
    class ConcretePrototype2 : Prototype
    {
        // Конструктор.
        public ConcretePrototype2(string id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            // Глубокое копирование.
            return new ConcretePrototype2(this.Id);
        }
    }
}
