using System;
using System.Reflection;

/// <summary>
/// Атрибуты
/// Атрибуты сборки - добавляются в файл AssemblyInfo.cs
/// </summary>
namespace _005_Attributes
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            object[] attributes = assembly.GetCustomAttributes(false);

            foreach (Attribute attribute in attributes)
            {
                Console.WriteLine("Attribute: {0}", attribute.GetType().Name);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
