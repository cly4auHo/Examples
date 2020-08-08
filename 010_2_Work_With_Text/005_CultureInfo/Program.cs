using System;
using System.Globalization;

/// <summary>
/// CultureInfo - 
/// Предоставляет информацию о конкретной культуре 
/// </summary>
namespace _005_CultureInfo
{
    class Program
    {
        static void Main()
        {
            // Получение информации о текущей культуре.
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            Console.WriteLine("Текущая локаль: {0}.", currentCulture);

            Console.ReadKey();

            // Информация о всех культурах доступных в системе.
            CultureInfo[] cultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures);
            Console.WriteLine("В системе определены {0} различные культуры.",
                cultureInfo.Length);

            foreach (CultureInfo ci in cultureInfo)
            {
                Console.WriteLine(ci.EnglishName + " | " + ci.ToString());
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
