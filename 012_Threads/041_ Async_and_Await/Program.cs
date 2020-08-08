using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Передача параметров в асинхронную операцию
/// </summary>
namespace _041__Async_and_Await
{
    class Program
    {
        static void Main()
        {
            FactorialAsync(5);
            FactorialAsync(6);
            Console.WriteLine("Некоторая работа");

            Factorial(7);
            // Задержка
            Console.ReadLine();
        }

        /// <summary>
        /// Определение асинхронного метода
        /// </summary>
        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }

        /// <summary>
        /// Расчет факториала
        /// </summary>
        static void Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            Thread.Sleep(3000);
            
            Console.WriteLine($"Факториал равен {result}");
        }


    }
}
