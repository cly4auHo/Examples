using System;

/// <summary>
///  System.Nullable<T>. 
///  Однако в различных ситуациях бывает удобно, чтобы объекты числовых 
///  типов данных имели значение null, то есть были бы не определены. 
/// Фактически запись ? является упрощенной формой использования структуры System.Nullable<T>. 
/// </summary>
namespace _0212_Generics
{
    class Program
    {
        static void Main()
        {
            // a - содержит неизвестное значение.
            int? a = null;
            int? b = a + 4; // b = null
            int? c = a * 5; // c = null

            // Фактически запись ? является упрощенной формой использования структуры System.Nullable<T>. 
            Nullable<int> a1 = null;
            Nullable<int> b1 = a1 + 4;
            Nullable<int> c1 = a1 *5;

            Console.WriteLine("a = ->{0}<-", a);
            Console.WriteLine("b = ->{0}<-", b);
            Console.WriteLine("c = ->{0}<-", c);

            Console.WriteLine(new string('-', 10));

            Console.WriteLine("a = ->{0}<-", a1);
            Console.WriteLine("b = ->{0}<-", b1);
            Console.WriteLine("c = ->{0}<-", c1);

            //Задержка
            Console.ReadKey();
        }
    }
}
