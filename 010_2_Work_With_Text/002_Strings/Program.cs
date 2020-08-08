﻿using System;

/// <summary>
/// Строковые литералы. Интернирование строк.
/// Метод Intern использует пул интернирования для поиска строки, равной значению str.
/// Если такая строка существует, то возвращается ссылка на нее в пуле интернирования.
/// Если эта строка отсутствует, ссылка на str добавляется в пул интернирования, 
/// а затем эта ссылка возвращается.
/// </summary>
namespace _002_Strings
{
    class Program
    {
        static void Main()
        {
            //1) @ - формат строки
            string @string = @"
                               Jack and Jill
                               Went up the hill...
                              ";

            Console.WriteLine(@string);

            // Создаем две строки.
            // Эти строковые переменные ссылаются на одно место в памяти.
            string string1 = "c:\\windows\\system32";
            string string2 = @"c:\windows\system32";

            // Демонстрация того, что ссылки действительно совпадают.
            Console.WriteLine("string1 = " + string1);
            Console.WriteLine("string2 = " + string2);
            Console.WriteLine("Object.ReferenceEqual(string1, string2): {0}",
                Object.ReferenceEquals(string1, string2));

            // Попытка создать еще одну строковую переменную, которая будет 
            // ссылаться на существующий литерал в пуле интернирования.
            Console.WriteLine("\nEnter some string:");
            // Метод String.Intern() - извлекает системную ссылку
            // на указанный строковой литерал из пула интернирования.
            string stringNew = String.Intern(Console.ReadLine());

            Console.WriteLine("Object.ReferenceEqual(string1, stringNew): {0}",
               ReferenceEquals(string1, stringNew));

            // Задержка.
            Console.ReadKey();
        }
    }
}
