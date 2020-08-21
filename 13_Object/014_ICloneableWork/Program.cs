using System;

/// <summary>
/// ICloneable
/// Поддерживает копирование, который создает новый экземпляр класса с тем же значением
/// как существующий экземпляр.
/// </summary>
namespace _014_ICloneableWork
{
    class Program
    {
        static void Main()
        {
            Point original = new Point(100, 100);
            Point clone = original.Clone() as Point;

            Console.WriteLine("Первая проверка");

            Console.WriteLine(original);
            Console.WriteLine(clone);

            // Изменяем clone.x (при этом original.x не изменится)
            clone.x = 0;

            // Проверка.
            Console.WriteLine("Вторая проверка после изменения");
            Console.WriteLine(original);
            Console.WriteLine(clone);

            // Задержка.
            Console.ReadKey();
        }
    }


    /// <summary>
    /// Глубокое копирование (Deep copy)
    /// </summary>
    public class Point : ICloneable
    {
        public int x, y;

        public Point()
        {

        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Реализация метода интерфейса ICloneable.
        public object Clone()
        {
            return new Point(this.x, this.y) as object;
        }

        public override string ToString()
        {
            return "X: " + x + " Y: " + y;
        }
    }
}
