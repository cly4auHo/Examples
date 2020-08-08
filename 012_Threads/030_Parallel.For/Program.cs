using System;
using System.Threading.Tasks;
using System.Diagnostics;

/// <summary>
/// Применение метода Parallel.For() для организации параллельно выполняемого цикла обработки данных.
/// Пример выполнять через (CTRL+F5).
/// </summary>
namespace _030_Parallel.For
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

            for (int i = 0; i < data.Length; i++)
            {
                // Инициализация данных в обычном цикле for.
                data[i] = i * i * i / 123;
            }

            // Останавливает измерение затраченного времени для интервала.
            timer.Stop();
           
            Console.WriteLine("Обычный цикл for      : " + timer.ElapsedTicks);

            // Обнуляем затраченное время.
            timer.Reset();

            // Делегат Action
            Action<int> transform = (int i) =>
            { 
                data[i] = i * i * i / 123; 
            };

            //Запускает измерение
            timer.Start();

            // Инициализация данных в параллельном цикле for.
            Parallel.For(0, data.Length, transform);

            // Останавливает измерение затраченного времени для интервала.
            timer.Stop();

            Console.WriteLine("Параллельный цикл for : " + timer.ElapsedTicks);

            // Внимание!
            // Выполнение метода Main() приостанавливается, 
            // пока не произойдет завершение работы метода For().

            Console.WriteLine("Основной поток завершен.");

            // Задержка
            Console.ReadKey();
        }
    }
}
