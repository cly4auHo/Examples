using System;
using System.Linq;
using DataContexts;

/// <summary>
/// Чтобы найти пересечение выборок, (элементы, которые присутствуют сразу в двух выборках), 
/// используется метод Intersect():
/// </summary>
namespace _013_SetOperations
{
    class Program
    {
        static void Main()
        {
            using (Model1 db = new Model1())
            {
                var phones = db.Phones.Where(p => p.Price < 25000)
                                      .Intersect(db.Phones.Where(p => p.Name.Contains("Samsung")));

                foreach (var item in phones)
                    Console.WriteLine("{0}.{1}", item.Id, item.Name);

                // Задержка
                Console.ReadLine();
            }
        }
    }
}
