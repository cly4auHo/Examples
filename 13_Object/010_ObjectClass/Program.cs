using System;

/// <summary>
/// Базовый класс Object.
/// </summary>
namespace _010_ObjectClass
{
    class MyDerivedClass : MyBaseClass
    {
        static void Main()
        {
            MyDerivedClass original = new MyDerivedClass();
            original.age = 27;
            original.name = "Alex";

            Console.WriteLine(original.age + " " + original.name + " " + MyDerivedClass.CompanyName);

            // Клонирование.
            // MemberwiseClone() - Создает неполную копию текущего объекта System.Object.
            MyDerivedClass clone = original.MemberwiseClone() as MyDerivedClass;
            Console.WriteLine(clone.age + " " + clone.name + " " + MyDerivedClass.CompanyName + "\n");

            // Проверка. 
            clone.age = 23;
            clone.name = "Konstantin";
            MyBaseClass.CompanyName = "ITEA";

            Console.WriteLine(original.age + " " + original.name + " " + MyDerivedClass.CompanyName);
            Console.WriteLine(clone.age + " " + clone.name + " " + MyDerivedClass.CompanyName);

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Базовый класс
    /// </summary>
    class MyBaseClass
    {
        public static string CompanyName = "Microsoft";
        public int age;
        public string name;
    }
}
