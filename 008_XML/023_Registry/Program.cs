using Microsoft.Win32;
using System;

/// <summary>
/// Редактирование реестра.
/// </summary>
namespace _023_Registry
{
    class Program
    {
        static void Main()
        {
            // RegistryKey - Представляет узел уровня раздела в реестре Windows.
            RegistryKey myKey = Registry.CurrentUser;

            // Для удаления тоже нужно иметь права редактирования.
            RegistryKey wKey = myKey.OpenSubKey("Software", true);

            // Вывод на экран всего содержимого ключа поименно.
            string[] keyNames = wKey.GetSubKeyNames();

            foreach (string name in keyNames)
            {
                if (name == "ITEA")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string(' ', 5) + name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine(new string(' ', 5) + name);
                }
            }

            // Теперь пытаемся удалить ключ.
            try
            {
                Console.WriteLine("Всего записей в {0}: {1}.", wKey.Name, wKey.SubKeyCount);
                wKey.DeleteSubKey("ITEA");

                Console.WriteLine("Запись \'ITEA\' успешно удалена из реестра!");
                Console.WriteLine("Теперь записей стало: {0}.", wKey.SubKeyCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                wKey.Close();
            }

            // Задержка
            Console.ReadKey();
        }
    }
}
