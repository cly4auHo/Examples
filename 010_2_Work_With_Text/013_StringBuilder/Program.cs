using System;
using System.Text;

/// <summary>
/// Работа с StringBuilder.
/// </summary>
namespace _013_StringBuilder
{
    class Program
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("StringBuilder ").Append("является ").Append("очень ... ");
            builder.AppendLine();
            
            string build1 = builder.ToString();

            builder.Append("быстрым");

            string build2 = builder.ToString();

            Console.WriteLine(build1);
            Console.WriteLine(build2);

            // Задежка.
            Console.ReadKey();
        }
    }
}
