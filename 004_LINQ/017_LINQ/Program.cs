using System;
using System.Linq;

/// <summary>
/// select - (Операция проекции) используется для 
/// производства конечного результата запроса.
/// </summary>
namespace _017_LINQ
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };

            // Построить запрос.
            var query = from x in numbers
                        select new Result() { Input = x, Output = x * 2 };

            // Выражение запроса выполняется в момент обращения к переменной запрса в foreach.
            numbers[0] = 777; 

            foreach (var item in query)
            {
                Console.WriteLine("Input = {0}, \t Output = {1}", item.Input, item.Output);
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс для получения результата
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Ввод
        /// </summary>
        public int Input { get; set; }

        /// <summary>
        /// Вывод
        /// </summary>
        public int Output { get; set; }
    }
}
