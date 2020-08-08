using System;

/// <summary>
/// System.Nullable<T>.
/// Операция поглощения - ??
/// Оператор ?? называется оператором null-объединения. 
/// Он применяется для установки значений по умолчанию для типов, 
/// которые допускают значение null. Оператор ?? возвращает левый операнд, 
/// если этот операнд не равен null. Иначе возвращается правый операнд. 
/// При этом левый операнд должен принимать null.
/// </summary>
namespace _024_Generics
{
    class Program
    {
        static void Main()
        {
            // x - содержит неизвестное значение.
            int? x = null;
            int? y;

            // равно 10, так как x равен null
            y = x ?? 10; // y = 10
            Console.WriteLine(y);

            Console.WriteLine(new string('-', 10));

            x = 3;
            // равно 3, так как x не равен null
            y = x ?? 10; // y = 3
            Console.WriteLine(x);

            // Задержка.
            Console.ReadKey();
        }
    }
}
