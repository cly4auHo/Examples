using System;
using System.IO;

/// <summary>
/// FileSystemWatcher
/// Постоянный мониторинг папки реализованный на c#
/// Отслеживание изменений в системе.
/// </summary>
namespace _014_FileSystemWatcher
{
    class Program
    {
        static void Main()
        {
            // Создание наблюдателя и сосредоточение его внимания на системном диске.
            FileSystemWatcher watcher = new FileSystemWatcher { Path = @"D:\" };

            // Зарегистрировать обработчики событий.
            watcher.Created += new FileSystemEventHandler(WatcherChanged);
            watcher.Deleted += WatcherChanged;
            
            // Начать мониторинг.
            watcher.EnableRaisingEvents = true;

            // Содержит сведения о произошедших изменениях.
            // WaitForChanged - Синхронный метод, возвращающий структуру, содержащую 
            // сведения о произошедших изменениях, с заданным типом изменений, 
            // которые вы хотите контролировать.
            WaitForChangedResult change = watcher.WaitForChanged(WatcherChangeTypes.All);

            // Возвращает или задает тип произошедшего изменения.
            Console.WriteLine(change.ChangeType);

            // Возвращает или задает имя файла или каталога, которая изменена.
            Console.WriteLine(change.Name);

            // Возвращает или задает имя исходного файла или каталога, который был переименован.
            Console.WriteLine(change.OldName);

            // Возвращает или задает значение, показывающее, истекло ли время ожидания операции.
            Console.WriteLine(change.TimedOut);

            // Задержка
            Console.ReadKey();
        }

        // Обработчик события.
        static void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Directory changed({0}): {1}", e.ChangeType, e.FullPath);
        }
    }
}
