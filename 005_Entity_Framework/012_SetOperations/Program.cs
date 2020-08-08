using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContexts;

/// <summary>
/// Для объединения двух выборок используется метод Union();
/// </summary>
namespace _012_SetOperations
{
    class Program
    {
        static void Main()
        {
            using (Model1 db = new Model1())
            {
                var ph = db.Phones
                    .Where(p => p.Price < 10000)
                    .Union(db.Phones.Where(p => p.Name.Contains("Samsung")));

                foreach (var item in ph)
                    Console.WriteLine("{0}.{1}", item.Id, item.Name);

                Console.WriteLine("------------------------------------------");
                Console.ReadKey();
                //Метод Union в качестве параметра принимает результаты второй выборки и объединяет ее с исходной.
                //При этом мы не можем объединить две разнородные выборки, например, таблицу, моделей телефонов и 
                //таблицу производителей телефонов. Однако уместна следующая запись:

                var result = db.Phones.Select(p => new { Name = p.Name })
                                      .Union(db.Companies.Select(c => new { Name = c.Name }));

                foreach (var item in result)
                {
                    Console.WriteLine("{0}", item.Name);
                }

                // Задержка
                Console.ReadLine();
            }
        }
    }
}
