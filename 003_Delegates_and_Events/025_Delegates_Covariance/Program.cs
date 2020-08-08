using System;

/// <summary>
/// Ковариантность обобщений.
/// Ковариантность обобщений в C# 4.0 ограничена интерфейсами и делегатами.
/// Ковариантность: позволяет использовать более конкретный тип, чем заданный изначально
/// </summary>
namespace _025_Delegates_Covariance
{
    class Program
    {
        delegate T MyDelegate<out T>();
        static void Main()
        {
            /*MyDelegate<Cat> delegateCat = new MyDelegate<Cat>(CatCreator);

            MyDelegate<Animal> delegateAnimal = delegateCat;*/

            //Или так
            MyDelegate<Animal> delegateAnimal = new MyDelegate<Cat>(CatCreator);

            Animal animal = delegateAnimal.Invoke();

            Console.WriteLine(animal.GetType().Name);

            // Задержка.
            Console.ReadKey();
        }

        public static Cat CatCreator()
        {
            return new Cat();
        }
    }

    class Animal { }
    class Cat : Animal { }
}
