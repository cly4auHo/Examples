using System;
using System.Text.RegularExpressions;

/// <summary>
/// Регулярные выражения.
/// </summary>
namespace _020_RegularExpressions
{
    class Program
    {
        static void Main()
        {
            // | - символ для указания вариантов шаблона (ИЛИ). 
            string pattern = "test|str|aaaa";

            string[] array = new string[4];

            array[0] = "some text with test in it";
            array[1] = "some text with str in it";
            array[2] = "some text with aaaa in it";
            array[3] = "some text with nothing in it";

            Regex regex = new Regex(pattern);

            foreach (string element in array)
            {
                if (regex.IsMatch(element))
                    Console.WriteLine("Строка \"{0}\" соответствует шаблону \"{1}\"", 
                        element, pattern);
                else
                    Console.WriteLine("Строка \"{0}\" НЕ соответствует шаблону \"{1}\"",
                        element, pattern);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
