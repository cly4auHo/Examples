using System;

/// <summary>
/// System.Nullable<T>
/// </summary>
namespace _026_Generics
{
    class Program
    {
        static void Main()
        {
            Nullable<int> a = 1;

            //  asValue - возвращает значение, указывающее, имеет ли текущий 
            // объект System.Nullable`1 допустимое значение своего базового типа.
            if (a.HasValue == true)
                Console.WriteLine("a is {0}.", a.Value);
            
            // Короткая нотация Nullable типа - "?", доступна только для C#.
            int? b = null;

            if (b.HasValue == true)
                Console.WriteLine("b is {0}", b.Value);
            else
                Console.WriteLine("b is null");

            // Задержка.
            Console.ReadKey();
        }
    }
}
