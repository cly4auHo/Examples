using System;

/// <summary>
///  Базовый класс Object.
/// </summary>
namespace _006_ObjectClass
{
    class Program
    {
        static void Main()
        {
            Object obj1 = new Object();
            Object obj2 = new Object();

            // Метод ReferenceEquals сравнивает две ссылки. Если ссылки на объекты идентичны, 
            // то возвращает true. (Определяет, совпадают ли указанные экземпляры System.Object).
            Console.WriteLine(ReferenceEquals(obj1, obj2));

            obj1 = obj2;

            Console.WriteLine(ReferenceEquals(obj1, obj2));

            // Задержка.
            Console.ReadKey();
        }
    }
}
