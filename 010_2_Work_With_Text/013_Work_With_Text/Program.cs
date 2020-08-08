using System;

/// <summary>
/// Варинты создания строк
/// </summary>
namespace _013_Work_With_Text
{
    class Program
    {
        static void Main()
        {
            // Использование полного имени типа
            // "Hello"
            System.String s = "Hello";
            Console.WriteLine(s);
            Console.WriteLine(s.GetHashCode());
            
            // Insert - Возвращает новую строку, в которой указанная строка 
            // вставлена по указанному индексу
            s = s.Insert(3, "rr");
            
            Console.WriteLine(s);
            Console.WriteLine(s.GetHashCode());
            // "---------------------------------------------------"
            // Еще один вариант создания
            String s2 = new string('-', 20);

            //"Hello-----------------------------------------------"
            //Конкатенация с присвоением 
            s += s2;  //s = s + s2;

            //"5"
            string s4 = 5.ToString();

            //"1 + 2 = 3"
            string s5 = String.Format("{0} + {1} = {2}", 1, 2, 1 + 2);

            // Задержка
            Console.ReadKey();
        }
    }
}
