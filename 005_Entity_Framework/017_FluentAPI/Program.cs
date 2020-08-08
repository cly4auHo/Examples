using System;
using System.Data.Entity;
using System.Linq;

namespace _017_FluentAPI
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new DropCreateAttendeeDb());

            using (var db = new CodeContext())
            {
                var query = from attendees in db.Attendees
                            select attendees;

                Console.WriteLine(query);
                Console.ReadKey();

                Console.WriteLine("Count - {0}", query.Count());
                Console.ReadKey();

                foreach (var item in query)
                {
                    Console.WriteLine("{0}.{1} <{2}>", item.AttendeeTrackingID, item.LastName, item.DateAdded);
                }
            }

            //Задержка
            Console.ReadKey();
        }
    }
}
