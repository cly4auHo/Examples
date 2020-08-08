using System;

/// <summary>
/// Динамические типы данных.
/// </summary>
namespace _036__Dynamic
{
    class Program
    {
        static void Main()
        {
            dynamic @dynamic = new MyClass("Hello");

            Console.WriteLine(@dynamic.Field);

            string variable = @dynamic.Method("World");

            Console.WriteLine(variable);

            @dynamic[0] = "Zero";
            @dynamic[1] = "One";
            @dynamic[2] = "Two";

            for (dynamic i = 0; i < 3; i++)
            {
                Console.WriteLine(@dynamic[i]);
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    class MyClass
    {
        /// <summary>
        /// Динамическое поле
        /// </summary>
        private dynamic field;

        /// <summary>
        /// Конструктор класса MyClass
        /// </summary>
        /// <param name="argument">Динамический аргумент конструктора класса</param>
        public MyClass(dynamic argument)
        {
            field = argument;
        }

        /// <summary>
        /// Динамическое автосвойства.
        /// </summary>
        public dynamic MyAutoProperty { get; set; }

        /// <summary>
        /// Динамическое свойство
        /// </summary>
        public dynamic Field
        {
            get { return field; }
            set { field = value; }
        }

        /// <summary>
        /// Динамический метод.
        /// </summary>
        public dynamic Method(dynamic argument)
        {
            return argument;
        }

        /// <summary>
        /// Динамический массив.
        /// </summary>
        dynamic[] array = new dynamic[3];

        /// <summary>
        /// Динамический индексатор.
        /// </summary>
        public dynamic this[dynamic index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
