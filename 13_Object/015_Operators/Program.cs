using System;

/// <summary>
/// Перегрузка операторов. 
/// </summary>
namespace _015_Operators
{
    class Program
    {
        static void Main()
        {
            Point a = new Point(0, 0);

            Console.WriteLine("a   = {0}", a);
            Console.WriteLine("a++ = {0}", a++);
            Console.WriteLine("a   = {0}", a);

            Console.WriteLine("a-- = {0}", a--);
            Console.WriteLine("a   = {0}", a);

            Console.WriteLine("++a = {0}", ++a);
            Console.WriteLine("a   = {0}", a);

            Console.WriteLine("--a = {0}", --a);
            Console.WriteLine("a   = {0}", a);

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

        // Перегруженный оператор ++.
        public static Point operator ++(Point p1)
        {
            return new Point(p1.x + 1, p1.y + 1);
        }

        // Перегруженный оператор --.
        public static Point operator --(Point p1)
        {
            return new Point(p1.x - 1, p1.y - 1);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.x, this.y);
        }
    }
}
