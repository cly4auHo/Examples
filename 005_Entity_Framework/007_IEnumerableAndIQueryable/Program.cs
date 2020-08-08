using System;
using System.Collections.Generic;
using System.Linq;
using DataContexts;

/// <summary>
/// Методы расширений LINQ могут возвращать два объекта: IEnumerable и IQueryable.
/// Интерфейс IEnumerable находится в пространстве имен System.Collections. 
/// Интерфейс IQueryable располагается в пространстве имен System.Linq.
/// </summary>
namespace _007_IEnumerableAndIQueryable
{
    class Program
    {
        static void Main()
        {
            using (Model1 db = new Model1())
            {
                IEnumerable<Phone> phone = db.Phones.ToList();
                
                //Console.ReadKey();
                phone = phone.Where(p => p.Id > 3);
                //Console.ReadKey();

                foreach (var item in phone)
                {
                    Console.WriteLine("{0}.{1}", item.Id, item.Name);
                }

                Console.WriteLine("---------------------------------");
                Console.ReadKey();

                IQueryable<Phone> phone1 = db.Phones;
                //Console.ReadKey();

                phone1 = phone1.Where(p => p.Id > 3);
                
                //Console.ReadKey();

                foreach (var item in phone1)
                {
                    Console.WriteLine("{0}.{1}", item.Id, item.Name);
                }

                Console.ReadLine();
            }
        }
    }
}
