using System;
using System.Threading;


/// <summary>
/// Класс Interlocked позволяет создавать простые операторы для атомарных операций с переменными. 
/// Например, операция i++ не является безопасной в отношении потоков. 
/// Она подразумевает извлечение значения из памяти, увеличение этого значения на 1 и его 
/// обратное сохранение в памяти. Такие операции могут прерываться планировщиком потоков. 
/// Класс Interlocked предоставляет методы, позволяющие выполнять инкремент, декремент, 
/// обмен и считывание значений в безопасной к потокам манере.
/// </summary>
namespace _018_Interlocked
{
    class Program
    {
        // Счетчик запущеных потоков
        static long counter;
        // Обект блокировки
        static object block = new object();

        static void Main()
        {
           
            Console.WriteLine("Ожидаемое значение счетчика = 10000000");
            
            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; ++i)
            {
                (threads[i] = new Thread(Procedure)).Start();
            }

            for (int i = 0; i < 10; ++i)
            { 
                threads[i].Join(); 
            }

            Console.WriteLine("Реальное значение счетчика  = {0}", counter);

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Увеличение счетчика
        /// </summary>
        static void Procedure()
        {
            for (int i = 0; i < 1000000; i++)
            {
                // Interlocked - Предоставляет атомарные операции для переменных, 
                // общедоступных нескольким потокам.
                // Interlocked.Increment(ref counter);

                //lock (block)
                {
                    counter++;
                }
            }
        }
    }
}
