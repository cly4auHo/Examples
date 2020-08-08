using System;
using System.Globalization;

/// <summary>
/// Вывод строк с использованием настроек культуры.
/// </summary>
namespace _007_FormattedStrings
{
    class Program
    {
        static void Main()
        {
            // Сумма, которую необходимо вывести на экран.
            double money = 262343.36;

            // Американская культура
            CultureInfo american = new CultureInfo("en-US");
            // Немецкая культура
            CultureInfo germany = new CultureInfo("de-DE");
            // Руская культура
            CultureInfo russian = new CultureInfo("ru-RU");

            // Форматируем строки под нужную культуру и сохраняем результат 
            // в переменной.
            // Для форматирования валюты используется описатель "C":
            string localMoney = money.ToString("C", american);
           
            string result = String.Format("Деньги США: {0}", localMoney);

            localMoney = money.ToString("C", germany);
            result += String.Format("\nДеньги Германии: {0}", localMoney);

            localMoney = money.ToString("C", russian);
            result += String.Format("\nДеньги России: {0}", localMoney);

            // Выводим содержимое на экран.
            Console.WriteLine(result);

            // Задержка
            Console.ReadKey();
        }
    }
}
