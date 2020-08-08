using System;
using System.Linq;
using DataContexts;

namespace _009_Sorting
{
    class Program
    {
        static void Main()
        {
            using (Model1 db = new Model1())
            {
                //Для упорядочивания полученных из данных по возрастанию служит метод OrderBy или оператор orderby;
                var phones = db.Phones.OrderBy(p => p.Name);
                foreach (Phone p in phones)
                    Console.WriteLine("{0}.{1} - {2}", p.Id, p.Name, p.Price);

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //Оператор orderby
                var phones1 = from p in db.Phones
                              orderby p.Name
                              select p;
                foreach (Phone p in phones1)
                    Console.WriteLine("{0}.{1} - {2}", p.Id, p.Name, p.Price);

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //Для сортировки по убыванию применяется метод OrderByDescending();
                var phones2 = db.Phones.OrderByDescending(p => p.Name);
                foreach (Phone p in phones2)
                    Console.WriteLine("{0}.{1} - {2}", p.Id, p.Name, p.Price);

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //Методы для сортировки данных по нескольким критериям 
                //ThenBy()(для сортировки по возрастанию) и ThenByDescending()(по убыванию)
                var phones3 = db.Phones
                    .Select(p => new { p.Name, Company = p.Company.Name, p.Price })
                    .OrderBy(p => p.Price)
                    .ThenBy(p => p.Company);
                foreach (var p in phones3)
                    Console.WriteLine("{0} - ({1}) - {2}", p.Name, p.Company, p.Price);

                //Задержка
                Console.ReadLine();
            }
        }
    }
}
