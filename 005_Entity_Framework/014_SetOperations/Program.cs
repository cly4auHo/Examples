using System;
using System.Linq;
using DataContexts;

/// <summary>
/// Если нам надо найти элементы первой выборки, которые отсутствуют во второй выборке, 
/// то мы можем использовать метод Except:
/// </summary>
namespace _014_SetOperations
{
    class Program
    {
        static void Main()
        {
            using (Model1 db = new Model1())
            {
                var selector1 = db.Phones.Where(p => p.Price < 25000); // Samsung Galaxy S5, Samsung Galaxy S4, Nokia Lumia 830, Nokia Lumia 930
                var selector2 = db.Phones.Where(p => p.Name.Contains("Samsung")); // Samsung Galaxy S4, Samsung Galaxy S4
                var phones = selector1.Except(selector2); // результат -  Nokia Lumia 830, Nokia Lumia 930

                foreach (var item in phones)
                    Console.WriteLine("{0}.{1}", item.Id, item.Name);

                // Задержка
                Console.ReadLine();
            }
        }
    }
}
