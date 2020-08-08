using System;
using System.Text.RegularExpressions;

/// <summary>
/// Регулярные выражения.
/// </summary>
namespace _022_RegularExpressions
{
    class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4}");

            MatchCollection collection = 
                regex.Matches("русский edu@glembitskij.com текст123ещерусскийsupport@glembitskij.comтекст");

            foreach (Match element in collection)
            {
                Console.WriteLine("{0,-25}  на {1,-3} позиции.", element.Value, element.Index);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
