using System;
using System.Linq;
using DataContexts;

namespace _008_SelectionAndProjection
{
    class Program
    {
        static void Main()
        {
            using (Model1 db = new Model1())
            {
                //Для выборки применяется метод Where
                var ph = db.Phones.Where(p => p.Company.Name == "Samsung");
                
                foreach (Phone p in ph)
                    Console.WriteLine("{0}.{1} - {2}", p.Id, p.Name, p.Price);

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //метод Find() для выборки одного объекта. НЕ является методом Linq, он определен у класса DbSet:
                Phone phone1 = db.Phones.Find(3);
                Console.WriteLine("{0}.{1} - {2}", phone1.Id, phone1.Name, phone1.Price);

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //методы Linq (FirstOrDefault() - вернет значение null)
                Phone phone2 = db.Phones.FirstOrDefault(p => p.Id == 4);
                if (phone2 != null)
                    Console.WriteLine("{0}.{1} - {2}", phone2.Id, phone2.Name, phone2.Price);

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //методы Linq First()
                Phone phone3 = db.Phones.First(t => t.Id == 4);
                if (phone3 != null)
                    Console.WriteLine("{0}.{1} - {2}", phone3.Id, phone3.Name, phone3.Price);

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //метод Select для проекции извлеченных данных на новый тип;
                //В итоге метод Select из полученных данных спроецирует новый тип и мы получим данные анонимного типа;
                var phone4 = db.Phones.Select(p => new { p.Name, p.Price, Company = p.Company.Name });
                foreach (var p in phone4)
                    Console.WriteLine("{0} ({1}) - {2}", p.Name, p.Company, p.Price);

                Console.WriteLine("---------------------------------------");
                Console.ReadLine();

                //также может быть определенный пользователем тип;
                var phone5 = db.Phones.Select(p => new Model { Name = p.Name, Price = p.Price, Company = p.Company.Name });
                foreach (var p in phone5)
                    Console.WriteLine("{0} ({1}) - {2}", p.Name, p.Company, p.Price);
                
                Console.ReadLine();
            }
        }
    }

    public class Model
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }
}
