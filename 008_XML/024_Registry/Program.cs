using Microsoft.Win32;
using System;

/// <summary>
/// // Редактирование реестра.
/// </summary>
namespace _024_Registry
{
    class Program
    {
        static void Main()
        {
            // Совершаем навигацию в нужное место и открываем его для записи.
            RegistryKey key = Registry.CurrentUser;
            RegistryKey subKey = key.OpenSubKey("Software", true);
            //Создает новый подраздел или открывает существующий для доступа на запись.
            RegistryKey subSubKey = subKey.CreateSubKey(@"ITEA");

            // Совершаем запись в реестр.
            // SetValue - Задает указанную пару "имя-значение".
            subSubKey.SetValue("TheStringName", "I contain string value.");
            subSubKey.SetValue("TheInt32Name", 1234567890);

            // Тип можно указать явно.
            subSubKey.SetValue("AnotherName", 1234567890, RegistryValueKind.String);

            //Close - Если содержимое раздела было изменено, следует закрыть раздел и записать его
            subKey.Close();
            subSubKey.Close();

            // Задержка на экране.
            Console.ReadKey();
        }
    }
}
