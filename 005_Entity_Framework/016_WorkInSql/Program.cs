using System;
using System.Data.SqlClient;

namespace _016_WorkInSql
{
    class Program
    {
        static void Main()
        {
            //строка подключения;
            using (DataModel db = new DataModel())
            {
                Console.WriteLine(db.Database.Connection.ConnectionString);

                Console.WriteLine("------------------------------------");
                Console.ReadKey();

                //Непосредственно для создания запроса нам надо использовать метод SqlQuery, который принимает в качестве параметра sql-выражение.
                var query = db.Database.SqlQuery<Companies>("SELECT * FROM Companies");

                foreach (var item in query)
                {
                    Console.WriteLine("{0}.{1}", item.Id, item.Name);
                }


                Console.WriteLine("------------------------------------");
                Console.ReadKey();

                //Другая версия метода SqlQuery() позволяет использовать параметры.
                SqlParameter param = new SqlParameter("@name", "%Samsung%");
                var query1 = db.Database.SqlQuery<Phones>("SELECT * FROM Phones WHERE Name LIKE (@name)", param);

                foreach (var item in query1)
                {
                    Console.WriteLine("{0}.{1} - {2}", item.Id, item.Name, item.Price);
                }

                Console.WriteLine("------------------------------------");
                Console.ReadKey();

                //метод ExecuteSqlCommand(), предоставляет возможность (удалять, обновлять уже существующие или вставлять новые записи) который возвращает количество затронутых командой строк;
                // вставка
                int inserted = db.Database.ExecuteSqlCommand("INSERT INTO Companies (Name) VALUES ('HTC')");
                Console.WriteLine(inserted);

                var query2 = db.Database.SqlQuery<Companies>("SELECT * FROM Companies");

                foreach (var item in query2)
                {
                    Console.WriteLine("{0}.{1}", item.Id, item.Name);
                }


                Console.WriteLine("------------------------------------");
                Console.ReadKey();

                // обновление
                int updated = db.Database.ExecuteSqlCommand("UPDATE Companies SET Name='Nokia' WHERE Id=3");
                Console.WriteLine(updated);
                // удаление
                int deleted = db.Database.ExecuteSqlCommand("DELETE FROM Companies WHERE Id=3");
                Console.WriteLine(deleted);
            }
        }
    }
}
