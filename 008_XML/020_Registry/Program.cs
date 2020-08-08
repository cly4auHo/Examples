using Microsoft.Win32;
using System;

/// <summary>
/// Структура реестра.
/// </summary>
namespace _020_Registry
{
    class Program
    {
        static void Main()
        {
            // Registry - это класс, предоставляющий эксклюзивный доступ к ключам реестра для простых операций.
            // RegistryKey - класс реализует методы для просмотра дочерних ключей, создания новых или 
            // чтения и модификации существующих, включая установку уровней безопасности для них.

            //  RegistryKey -Представляет узел уровня раздела в реестре Windows
            RegistryKey[] keys = new RegistryKey[] {
                 /*это поле считывает базовый ключ реестра HKEY_CLASSES_ROOT.*/
                 Registry.ClassesRoot,
                 /*ключ реестра HKEY_CURRENT_USER*/
                 Registry.CurrentUser,
                 /*базовый ключ реестра HKEY_LOCAL_MACHINE.*/
                 Registry.LocalMachine,
                 /*базовый ключ реестра HKEY_USERS.*/
                 Registry.Users,
                 /*поле считывает базовый ключ реестра HKEY_CURRENT_CONFIG.*/
                 Registry.CurrentConfig,
                 /*Базовый ключ реестра раздел HKEY_PERFORMANCE_DATA.*/
                 Registry.PerformanceData
                };

            foreach (RegistryKey key in keys)
            {
                Console.WriteLine("{0} - всего элементов: {1}.", key.Name, key.SubKeyCount);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
