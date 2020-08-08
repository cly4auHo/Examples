using System;
using System.Diagnostics;
using System.Threading.Tasks;

/// <summary>
/// Сравнение последовательного и параллельного выполнения цикла for.
/// Пример выполнять через (CTRL+F5).
/// </summary>
namespace _031_Parallel.For
{
    class Program
    {
        static void Main()
        {
            int[] data = new int[100000000];

            // Stopwatch - Предоставляет набор методов и свойств, которые можно 
            // использовать для точного измерения затраченного времени
            Stopwatch timer = new Stopwatch();

            //Запускает измерение
            timer.Start();

            // Параллельная инициализация.
            Parallel.For(0, data.Length, i => data[i] = i);

            // Останавливает измерение затраченного времени для интервала.
            timer.Stop();

            Console.WriteLine("Параллельная инициализация      : {0} секунд.", timer.Elapsed.TotalSeconds);

            // Обнуляем затраченное время.
            timer.Reset();

            //Запускает измерение
            timer.Start();

            // Последовательная инициализация.
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            // Останавливает измерение затраченного времени для интервала.
            timer.Stop();

            Console.WriteLine("Последовательная инициализация  : {0} секунд.\n", timer.Elapsed.TotalSeconds);

            // Обнуляем затраченное время.
            timer.Reset();

            timer.Start();

            // Параллельное преобразование.
            Parallel.For(0, data.Length, i => data[i] = i * i * i / 123);

            timer.Stop();
            Console.WriteLine("Параллельное преобразование     : {0} секунд.", timer.Elapsed.TotalSeconds);
            timer.Reset();

            timer.Start();

            for (int i = 0; i < data.Length; i++) // Последовательное преобразование.
            {
                data[i] = i * i * i / 123;
            }

            timer.Stop();
            
            Console.WriteLine("Последовательное преобразование : {0} секунд.", timer.Elapsed.TotalSeconds);
            
            timer.Reset();

            Console.WriteLine("\nОсновной поток завершен.");

            // Задержка
            Console.ReadKey();
        }
    }
}
