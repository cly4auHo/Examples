using System;

/// <summary>
/// Перегрузка операторов.
/// </summary>

// Синтаксис перегрузки оператора.
// Point operator + (Point p1, Point p2) - метод, где:
// Point   -  тип возвращаемого методом значения,
// operator +  - имя метода,
// (Point p1, Point p2) - аргументы метода.

namespace _013_Operators
{
    class Program
    {
        static void Main()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);

            Point c = a + b;

            Console.WriteLine("c = {0}", c);

            // Delay.
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

        // Использовать ключевое слово operator, можно только вместе с ключевым словом static !

        /// <summary>
        ///  Перегрузка оператора +.
        /// </summary>
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        /// <summary>
        /// Перегрузка ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.x, this.y);
        }
    }
}
