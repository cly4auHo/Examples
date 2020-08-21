using System;

/// <summary>
/// Перегрузка операторов. 
/// </summary>
namespace _017_Operators
{
    class Program
    {
        static void Main()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);

            Console.WriteLine("a < b = {0}", a < b);
            Console.WriteLine("a > b = {0}", a > b);

            Console.WriteLine("a <= b = {0}", a <= b);
            Console.WriteLine("a >= b = {0}", a >= b);

            Console.WriteLine(new string('-', 15));

            Point c = new Point(1, 1);

            Console.WriteLine("a <= c = {0}", a <= c);
            Console.WriteLine("a >= c = {0}", a >= c);

            // Задержка.
            Console.ReadKey();
        }
    }
    public struct Point : IComparable
    {
        // Координаты точки.
        private int x, y;

        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        public static bool operator <(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) < 0);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) > 0);
        }

        public static bool operator <=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) <= 0);
        }

        public static bool operator >=(Point p1, Point p2)
        {
            return (p1.CompareTo(p2) >= 0);
        }


        // Реализация интерфейса IComparable.

        public int CompareTo(object obj)
        {
            if (obj is Point)
            {
                Point p = (Point)obj;

                if (this.x > p.x && this.y > p.y)
                {
                    return 1;
                }
                else if (this.x < p.x && this.y < p.y)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
