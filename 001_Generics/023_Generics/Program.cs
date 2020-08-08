using System;

/// <summary>
/// System.Nullable<T>.
/// Сравнение значений
/// </summary>
namespace _023_Generics
{
    class Program
    {
        static void Main()
        {
            // a - содержит неизвестное значение.
            int? x = null;
            int? y = -5; // b = -5

            // При сравнении операндов один из которых = null - результатом сравнения всегда будет - false.
            // Следовательно, нельзя расчитывать на истинность (правильность) результата.
            if (x >= y)
                Console.WriteLine("x >= y");
            else
                Console.WriteLine("x < y");

            // Сравнивать операнды (Nullable) есть смысл только для проверки - оба ли содержат null?
            // И если оба операнда содержат null, то результатом сравнения будет - true.
            y = null;

            if (x == y)
                Console.WriteLine("x == y");
            else
                Console.WriteLine("x != y");

            // Задержка.
            Console.ReadKey();
        }
    }
}
