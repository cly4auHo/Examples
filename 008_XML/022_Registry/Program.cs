using Microsoft.Win32;
using System;

/// <summary>
/// Редактирование реестра.
/// </summary>
namespace _022_Registry
{
    class Program
    {
        static void Main()
        {
            // RegistryKey - Представляет узел уровня раздела в реестре Windows.
            RegistryKey myKey = Registry.CurrentUser;

            // Второй аргумент (true) говорит о том, что будет совершаться запись.
            RegistryKey wKey = myKey.OpenSubKey("Software", true);

            try
            {
                Console.WriteLine("Всего записей в {0}: {1}.", wKey.Name, wKey.SubKeyCount);

                // Попытка создать новый ключ.
                RegistryKey newKey = wKey.CreateSubKey("ITEA");
                // Запись прошла успешно в HKEY_CURRENT_USER\Software\...

                Console.WriteLine("Запись \'{0}\' успешно внесена в реестр!", newKey.Name);
                Console.WriteLine("Теперь записей стало: {0}.", wKey.SubKeyCount);
            }
            catch (Exception e)
            {
                // Если возникает проблема - выводим сообщение о ней на экран.
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Закрыть ключ нужно обязательно.
                myKey.Close();
            }

            // Задержка на экране.
            Console.ReadKey();
        }
    }
}
