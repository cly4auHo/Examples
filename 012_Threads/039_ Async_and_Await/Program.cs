using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _039__Async_and_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            // Вызов асинхронного метода
            FactorialAsync();

            Console.WriteLine("Введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа равен {n * n}");

            //Задержка
            Console.Read();
        }

        /// <summary>
        /// Определение асинхронного метода
        /// </summary>
        static async void FactorialAsync()
        {
            // выполняется синхронно
            Console.WriteLine("Начало метода FactorialAsync");
            // выполняется асинхронно
            await Task.Run(() => Factorial());
            
            Console.WriteLine("Конец метода FactorialAsync");
        }

        static void Factorial()
        {
            Console.WriteLine("Поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            int result = 1;

            for (int i = 1; i <= 6; i++)
            {
                result *= i;
            }

            Thread.Sleep(8000);
            Console.WriteLine(@"Факториал равен {0}", result);
        }
    }
}
