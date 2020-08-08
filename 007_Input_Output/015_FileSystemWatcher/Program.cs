using System;
using System.IO;

/// <summary>
/// FileSystemWatcher
/// Постоянный мониторинг папки реализованный на c#
/// Отслеживание переименования файла.
/// </summary>
namespace _015_FileSystemWatcher
{
    class Program
    {
        static void Main()
        {
            // Создание наблюдателя.
            FileSystemWatcher watcher = new FileSystemWatcher(@"E:\ITEA - Продвинутый курс по С#\008_Ввод-вывод\Testing");
            
            // Зарегистрировать обработчики событий.
            watcher.Renamed += new RenamedEventHandler(WatcherRenamed);

            // Начать мониторинг.
            watcher.EnableRaisingEvents = true;

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// // Обработчик события.
        /// </summary>
        static void WatcherRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Renamed from {0} to {1}",
                // OldFullPath - Возвращает предыдущих полный путь файла или каталога.
                // FullPath - Возвращает полный путь для файла или каталога.
                e.OldFullPath, e.FullPath);
        }
    }
}
