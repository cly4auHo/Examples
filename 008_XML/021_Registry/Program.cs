using Microsoft.Win32;
using System;

/// <summary>
/// Навигация по реестру.
/// </summary>
namespace _021_Registry
{
    class Program
    {
        static void Main()
        {
            // RegistryKey -Представляет узел уровня раздела в реестре Windows
            // Процесс получения ссылки на объект RegistryKey называется открытием ключа.
            RegistryKey myKey = Registry.LocalMachine;
           
            // OpenSubKey - Возвращает подраздел с доступом только для чтения.
            RegistryKey software = myKey.OpenSubKey("Software");
            RegistryKey microsoft = software.OpenSubKey("Microsoft");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("{0} - имеет {1} элементов.", 
                software.Name, software.SubKeyCount);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("{0} - имеет {1} элементов.", microsoft.Name, microsoft.SubKeyCount);

            // Close() - Если содержимое раздела было изменено, следует 
            // закрыть раздел и записать его на диск.
            software.Close();
            microsoft.Close();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(new string('-', 20));

            // Попытка открыть несуществующий ключ. Переменной software будет присвоено значение NULL.
            software = myKey.OpenSubKey("NonExistName");

            try
            {
                // Попытка обратится к переменной, значение которой не присвоено.
                Console.WriteLine("Открыли узел: {0}.", software.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}\n{1}", e.Message, e.GetType());
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
