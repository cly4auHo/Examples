﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

/// <summary>
/// Применение метода Parallel.ForEach() для организации параллельно выполняемого цикла обработки данных.
///  Пример выполнять через (CTRL+F5).
/// </summary>
namespace _033_Parallel.ForEach
{
    class Program
    {
        static void Main()
        {
            IList<Element> elements = new List<Element>();

            // Недопустимо инициализировать коллекцию в цикле foreach.
            //foreach (Element element in elements)            
            //    element = new Element();

            // Инициализация коллекции в 10 000 000 элементов.
            for (int i = 0; i < 10000000; i++)
            {
                elements.Add(new Element() { A = i });
            }

            Stopwatch timer = new Stopwatch();

            timer.Start();

            // Последовательное преобразование.
            foreach (Element element in elements)
            { 
                element.A = 111 * 222 * 333 / 444; 
            }

            timer.Stop();
            Console.WriteLine("Обычный цикл foreach      : " + timer.ElapsedTicks);
            timer.Reset();

            timer.Start();

            // Параллельное преобразование.
            Parallel.ForEach(elements, element => element.A = 111 * 222 * 333 / 444);

            timer.Stop();
            Console.WriteLine("Параллельный цикл ForEach : " + timer.ElapsedTicks);

            Console.WriteLine("\nОсновной поток завершен.");

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Класс Element
        /// </summary>
        class Element
        {
            /// <summary>
            /// Авто свойство A
            /// </summary>
            public int A { get; set; }
        }
    }
}
