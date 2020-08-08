using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person { Name = "Holly", Age = 34 },
                new Person { Name = "Tom", Age = 6 },
                new Person { Name = "John", Age = 33 },
                new Person { Name = "William", Age = 13 },
                new Person { Name = "Robin", Age = 18 }
            };

            // person - переменная диапазона
            var adultPeopleNames = from person in people
                                   where person.Age >= 18
                                   select person.Name;

            foreach (var item in adultPeopleNames)
            {
                Console.WriteLine("Name: {0}", item);
            }

            Console.ReadKey();
        }
    }
}
