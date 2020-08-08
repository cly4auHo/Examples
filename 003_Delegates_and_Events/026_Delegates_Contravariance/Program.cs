using System;

/// <summary>
/// Контравариантность обобщений.
/// Контравариантность обобщений в C# 4.0 ограничена интерфейсами и делегатами.
/// Контравариантность: позволяет использовать более универсальный тип, чем заданный изначально
/// </summary>
namespace _026_Delegates_Contravariance
{
    class Program
    {
        delegate void MyDelegate<in T>(T a);
        static void Main()
        {
            MyDelegate<Animal> delegateAnimal = new MyDelegate<Animal>(CatUser);
            MyDelegate<Cat> delegateCat = delegateAnimal;

            delegateAnimal(new Animal());
            delegateCat(new Cat());

            // Задержка.
            Console.ReadKey();
        }

        public static void CatUser(Animal animal)
        {
            Console.WriteLine(animal.GetType().Name);
        }
    }

    class Animal { }
    class Cat : Animal { }
}
