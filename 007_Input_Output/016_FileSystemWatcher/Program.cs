using System;
using System.IO;

/// <summary>
/// При наблюдении за файловой системой число изменений может превысить возможности FileSystemWatcher.
/// Когда происходит слишком много событий, FileSystemWatcher генерирует событие Error.
/// </summary>
namespace _016_FileSystemWatcher
{
    class Program
    {
        static void Main()
        {
            // Создание наблюдателя.
            FileSystemWatcher watcher = new FileSystemWatcher(@".");
            //watcher.Path = @"D:\TESTDIR";

            // Зарегистрировать обработчики событий.
            watcher.Error += new ErrorEventHandler(WatcherError);

            // Начать мониторинг.
            watcher.EnableRaisingEvents = true;

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// // Обработчик события.
        /// </summary>
        static void WatcherError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("Error {0}", e.GetException());
        }
    }
}
