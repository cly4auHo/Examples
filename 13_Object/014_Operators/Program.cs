using System;

/// <summary>
/// Перегрузка операторов.
/// </summary>
namespace _014_Operators
{
    class Program
    {
        static void Main()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);

            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);

            Point c = new Point(0, 0);
            c += a;
            Console.WriteLine("c = {0}", c);

            // Задержка.
            Console.ReadKey();
        }
    }

    public struct Point
    {
        // Координаты точки.
        private int x, y;

        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }

        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.x * p2.x, p1.y * p2.y);
        }

        public static Point operator /(Point p1, Point p2)
        {
            return new Point(p1.x / p2.x, p1.y / p2.y);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.x, this.y);
        }
    }
}
