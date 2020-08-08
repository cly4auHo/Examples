using System;
using System.Linq;
using DataContexts;

namespace _011_Grouping
{
    class Program
    {
        static void Main()
        {
            using (Model1 db = new Model1())
            {
                //Чтобы сгруппировать данные по определенным параметрам используются оператор group by или метод GroupBy().
                var groups = from p in db.Phones
                             group p by p.Company.Name;
                foreach (var g in groups)
                {
                    Console.WriteLine(g.Key);
                    foreach (var p in g)
                        Console.WriteLine("{0} - {1}", p.Name, p.Price);
                    Console.WriteLine();
                }

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //Кроме свойства Key у группы есть свойство Count
                var groups1 = db.Phones.GroupBy(p => p.Company.Name);
                foreach (var g in groups1)
                {
                    Console.WriteLine("{0} - {1}", g.Key, g.Count());
                    foreach (var p in g)
                        Console.WriteLine("{0} - {1}", p.Name, p.Price);
                    Console.WriteLine();
                }

                // Задержка
                Console.ReadLine();
            }
        }
    }
}
