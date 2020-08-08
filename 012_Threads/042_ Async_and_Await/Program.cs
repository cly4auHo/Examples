using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Получение результата из асинхронной операции
/// </summary>
namespace _042__Async_and_Await
{
    class Program
    {
        static void Main()
        {
            FactorialAsync(5);
            FactorialAsync(6);
            Console.WriteLine("Некоторая работа");

            int res = Factorial(7);
            Console.WriteLine($"Факториал равен {res}");

            // Задержка
            Console.ReadLine();
        }

        /// <summary>
        /// Определение асинхронного метода
        /// </summary>
        static async void FactorialAsync(int n)
        {
            int x = await Task.Run(() => Factorial(n));
            Console.WriteLine($"Факториал равен {x}");
        }

        /// <summary>
        /// Расчет факториала
        /// </summary>
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            Thread.Sleep(3000);
            
            return result;
        }
    }
}
