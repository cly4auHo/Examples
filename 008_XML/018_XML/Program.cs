using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;

namespace _018_XML
{
    class Program
    {
        static void Main()
        {
            // NameValueCollection -  Представляет коллекцию связанных ключей System.String и 
            // значений System.String, доступ к которым можно получить с помощью ключа или индекса.
            // ConfigurationManager - Предоставляет доступ к файлам конфигурации для клиентских приложений.
            // AppSettings - Получает данные System.Configuration.AppSettingsSection для конфигурации текущего
            // приложения по умолчанию.
            NameValueCollection allAppSettings = ConfigurationManager.AppSettings;
            Int32 counter = 0;
            IEnumerator settingEnumerator = allAppSettings.Keys.GetEnumerator();

            while (settingEnumerator.MoveNext())
            {
                Console.WriteLine("Key: {0}  Value: {1}", allAppSettings.Keys[counter], allAppSettings[counter]);
                counter++;
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
