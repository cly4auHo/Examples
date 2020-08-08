using System;
using System.Linq;
using DataContexts;

/// <summary>
/// Linq to Entities поддерживает обращение к встроенным функциями SQL 
/// через специальные методы Count, Sum и т.д.
/// Метод Count() позволяет найти количество элементов в выборке;
/// </summary>
namespace _015_AggregateOperations
{
    class Program
    {
        static void Main()
        {
            using (Model1 db = new Model1())
            {
                int num1 = db.Phones.Count();
                // найдем кол-во записей, которые в названии содержат Samsung
                int num2 = db.Phones.Count(p => p.Name.Contains("Samsung"));

                Console.WriteLine("Number Phones - {0}", num1);
                Console.WriteLine("Number of Phones Samsung - {0}", num2);

                Console.WriteLine("-------------------------------------------");
                Console.ReadKey();

                //Для нахождения минимального, минимального и среднего значений по выборке 
                //применяются функции Min(), Max() и Average() соответственно. 

                //минимальная цена
                int minP = db.Phones.Min(p => p.Price);

                // максимальная цена
                int maxP = db.Phones.Max(p => p.Price);

                // средняя цена на телефоны фирмы Samsung
                double avgP = db.Phones.Where(p => p.Company.Name == "Samsung")
                                       .Average(p => p.Price);

                // средняя цена на все телефоны
                double avgP1 = db.Phones.Average(p => p.Price);

                Console.WriteLine("Min price - {0}", minP);
                Console.WriteLine("Max price - {0}", maxP);
                Console.WriteLine("Avg price (company samsung) - {0}", avgP);
                Console.WriteLine("Avg price (all phones) - {0}", avgP1);

                Console.WriteLine("-------------------------------------------");
                Console.ReadKey();

                //Для получения суммы значений используется метод Sum():

                // суммарная цена всех телефонов
                int sum1 = db.Phones.Sum(p => p.Price);

                // суммарная цена всех моделей фирмы Samsung
                int sum2 = db.Phones.Where(p => p.Name.Contains("Samsung"))
                                    .Sum(p => p.Price);

                // суммарная цена всех моделей фирмы Samsung
                int sum3 = db.Phones.Where(p => p.Name.Contains("Nokia"))
                                    .Sum(p => p.Price);

                Console.WriteLine("Total price (all) - {0}", sum1);
                Console.WriteLine("Total price (company samsung) - {0}", sum2);
                Console.WriteLine("Total price (company nokia) - {0}", sum3);

                // Задержка
                Console.ReadLine();
            }
        }
    }
}
