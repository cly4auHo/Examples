using System;
using System.Collections.Specialized;
using System.Configuration;

namespace _017_XML
{
    class Program
    {
        static void Main()
        {

            // 1 Предоставляет доступ к чтению  общих параметров конфигурации.
            string value = ConfigurationSettings.AppSettings["Key1"];
            Console.WriteLine(value);
            Console.WriteLine(new string('-', 12));


            // 2 Представляет коллекцию связанных ключей System.String и значений System.String,
            // доступ к которым можно получить с помощью ключа или индекса.
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            Console.WriteLine(appSettings["Key1"]);
            Console.WriteLine(appSettings[0]);

            Console.WriteLine(new string('-', 12));

            // 3
            for (int i = 0; i < appSettings.Count; i++)
            {
                Console.WriteLine(appSettings[i]);
            }

            Console.WriteLine(new string('-', 12));

            // 4
            foreach (string item in appSettings)
            {
                Console.WriteLine(item);
                Console.WriteLine(appSettings[item]);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
