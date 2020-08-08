using System;
using System.IO;
using System.Threading;

/// <summary>
/// Ручная реализация блокировки.
/// Interlocked.CompareExchange - Безопасно проверяет два значения на эквивалентность. 
/// Если они эквивалентны, изменяет одно из значений на третье
/// </summary>
namespace _019_Interlocked
{
    class Program
    {
        static Random random = new Random();
        static SpinLock block = new SpinLock(10); // Интервал 10 млск.

        static FileStream stream = 
            File.Open("log.txt", FileMode.Create, FileAccess.Write, FileShare.None);
        
        static StreamWriter writer = new StreamWriter(stream);
        static void Main()
        {
            Thread[] threads = new Thread[50];

            for (uint i = 0; i < 50; ++i)
            {
                threads[i] = new Thread(Function);
                threads[i].Start();
            }

            // Delay
            //Console.ReadKey();
        }

        /// <summary>
        /// Будет запускаться в отдельном потоке.
        /// </summary>
        static void Function()
        {
            using (new SpinLockManager(block)) // Вызывается block.Enter();
            {
                writer.WriteLine("Поток {0} запускается.", Thread.CurrentThread.GetHashCode());
                writer.Flush(); // Очищает буфер writer и записывает данные в файл.
            }   // Вызывается метод - Dispose() { block.Exit(); }

            int time = random.Next(10, 200);
            Thread.Sleep(time); // Усыпляется поток на случайный период времени.

            using (new SpinLockManager(block)) // Вызывается block.Enter();
            {
                writer.WriteLine("Поток [{0}] завершается.", Thread.CurrentThread.GetHashCode());
                writer.Flush(); // Очищает буфер writer и записывает данные в файл.
            }   // Вызывается метод - Dispose() { block.Exit(); }
        }

    }

    /// <summary>
    /// SpinLock - аналог класса Monitor
    /// </summary>
    public class SpinLock
    {
        // Флаг [0 - блок свободен. 1 - блок занят].
        int block;

        //  Интервал через который потоки проверяют переменную block.
        int wait;

        /// <summary>
        /// Конструктор класса SpinLock
        /// </summary>
        public SpinLock(int wait)
        {
            this.wait = wait;
        }

        /// <summary>
        /// Установить блокировку (аналог - Monitor.Enter).
        /// </summary>
        public void Enter()
        {
            // Метод CompareExchange() [ Алгоритм работы ]
            // 1. Сравнивает начальное значение первого аргумента с третьим аргументом.
            // 2. Если первый аргумент равен третьему аргументу, то в первый аргумент записывается значение второго аргумента.
            // 3. Иначе, если первый аргумент не равен третьему аргументу, то первый аргумент остается без изменения.
            // 4. Возвращает начальное значение первого аргумента (каждый раз).
            int result = Interlocked.CompareExchange(ref block, 1, 0);

            while (result == 1)
            {
                // Блокировка занята, ожидать.
                Thread.Sleep(wait);
                result = Interlocked.CompareExchange(ref block, 1, 0);
            }
        }

        /// <summary>
        /// Сбросить блокировку (аналог - Monitor.Exit).
        /// </summary>
        public void Exit()
        {
            Interlocked.Exchange(ref block, 0);
        }
    }

    /// <summary>
    /// Логика работы конструкции - lock.
    /// </summary>
    public class SpinLockManager : IDisposable
    {
        SpinLock block;
        public SpinLockManager(SpinLock block)
        {
            this.block = block;
            block.Enter();
        }

        public void Dispose()
        {
            block.Exit();
        }
    }
}
