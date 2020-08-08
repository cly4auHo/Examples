using System;
using System.Linq;

using DataContexts;

namespace _010_Join
{
    class Program
    {
        static void Main()
        {
            using (Model1 db = new Model1())
            {
                //Для объединения таблиц по определенному критерию используется метод Join. Имеет общий критерий - id компании;
                var phones = db.Phones.Join(db.Companies, // второй набор
                    p => p.CompanyId, // свойство-селектор объекта из первого набора
                    c => c.Id, // свойство-селектор объекта из второго набора
                    (p, c) => new // результат
                    {
                        p.Id,
                        p.Name,
                        Company = c.Name,
                        p.Price
                    });
                foreach (var p in phones)
                    Console.WriteLine("{0}.{1} [{2}] - {3}", p.Id, p.Name, p.Company, p.Price);

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //Оператор join
                var phones1 = from p in db.Phones
                              join c in db.Companies on p.CompanyId equals c.Id
                              select new { p.Id, Name = p.Name, Company = c.Name, Price = p.Price };
                foreach (var p in phones1)
                    Console.WriteLine("{0}.{1} [{2}] - {3}", p.Id, p.Name, p.Company, p.Price);

                //Задержка
                Console.ReadLine();
            }
        }
    }
}
