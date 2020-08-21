using System;

/// <summary>
///  Перегрузка операторов. 
/// </summary>
namespace _016_Operators
{
    class Program
    {
        static void Main()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);

            Console.WriteLine("a == b = {0}", a == b);
            Console.WriteLine("a != b = {0}", a != b);

            Console.WriteLine(new string('-', 15));

            Point c = new Point(1, 1);

            Console.WriteLine("a == c = {0}", a == c);
            Console.WriteLine("a != c = {0}", a != c);

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

        // Перегруженный оператор ==.
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        // Перегруженный оператор !=.
        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.x, this.y);
        }

        // Переопределение Equals() 
        // В исходной реализации, по умолчанию, Equals() поддерживает сравнение только ссылочных типов.
        // Переопределение его для сравнения структурных типов.
        public override bool Equals(object o)
        {
            if (o is Point)
            {
                if (((Point)o).x == this.x && ((Point)o).y == this.y)
                    return true;
            }
            return false;
        }

        // Переопределение GetHashCode() - обязательна при переопределении Equals().
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
