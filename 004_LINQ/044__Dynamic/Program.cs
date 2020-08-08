using System;

/// <summary>
/// Динамические типы данных.
/// </summary>
namespace _044__Dynamic
{
    class Program
    {
        static void Main()
        {
            dynamic a = new Point(1, 1);
            dynamic b = new Point(2, 2);

            dynamic c = a + b;

            dynamic @int = 10;

            Console.WriteLine(c);

            // Задержка.
            Console.ReadKey();
        }
    }
    struct Point
    {
        dynamic x;
        dynamic y;
        public Point(dynamic x, dynamic y)
        {
            this.x = x;
            this.y = y;
        }

        // Один из параметров бинарного оператора, должен иметь существующий тип.
        public static dynamic operator +(Point pointA, dynamic pointB)
        {
            return new Point(pointA.x + pointB.x, pointA.y + pointB.y);
        }

        // В унарных операторах недопустимо использовать динамические типы (вообще).

        // public static dynamic operator ++(dynamic pointA) - так недопустимо.

        public static Point operator ++(Point pointA)
        {
            return new Point(pointA.x + 1, pointA.y + 1);
        }

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1}", x, y);
        }
    }
}
