using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Делегат Action является обобщенным, принимает параметры и возвращает значение void:
/// public delegate void Action<T>(T obj)
/// </summary>
namespace _022__Action
{
    class Program
    {
        static void Main()
        {
            Action<int, int> additioOperation = Add;
            //Action<int, int> additioOperation = Add;

            additioOperation(20, 10);

            Action<int, int> subtractionOperation = new Action<int, int>(Substract);
            //Action<int, int> subtractionOperation = Substract;

            subtractionOperation.Invoke(20, 10);

            //Задержка
            Console.ReadKey();
        }

        static void Add(int x1, int x2)
        {
            Console.WriteLine("Сумма чисел: " + (x1 + x2));
        }
        static void Substract(int x1, int x2)
        {
            Console.WriteLine("Разность чисел: " + (x1 - x2));
        }
    }
}
