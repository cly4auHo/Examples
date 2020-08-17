using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Принцип подстановки Лисков (Liskov Substitution Principle) представляет собой 
/// некоторое руководство по созданию иерархий наследования.
/// В общем случае данный принцип можно сформулировать так:
/// Должна быть возможность вместо базового типа подставить любой его подтип.
/// Фактически принцип подстановки Лисков помогает четче сформулировать иерархию классов, 
/// определить функционал для базовых и производных классов и избежать возможных проблем 
/// при применении полиморфизма.
/// </summary>
namespace _03_Liskov_Substitution_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            Console.WriteLine(rect.Height);
            Console.WriteLine(rect.Width);
            
            TestRectangleArea(rect);

            Console.WriteLine(new string('-',40));

            TestRectangleArea1(rect);

            Console.Read();
        }

        /// <summary>
        /// Проблема
        /// </summary>
        /// <param name="rect"></param>
        public static void TestRectangleArea(Rectangle rect)
        {
            rect.Height = 5;
            rect.Width = 10;
            if (rect.GetArea() != 50)
            {
                Console.WriteLine(rect.GetArea());
                Console.WriteLine("Некорректная площадь!");
            }
        }

        // Иногда для выхода из подобных ситуаций прибегают к специальному хаку, 
        // который заключается в проверке объекта на соответствие типам:
        // Но такая проверка не отменяет того факта, что с архитектурой классов что-то не так. 
        public static void TestRectangleArea1(Rectangle rect)
        {
            if (rect is Square)
            {
                rect.Height = 5;

                if (rect.GetArea() != 25)
                {
                    Console.WriteLine(rect.GetArea());
                    Console.WriteLine("Некорректная площадь!");
                }
            }
            else if (rect is Rectangle)
            {
                rect.Height = 5;
                rect.Width = 10;

                if (rect.GetArea() != 50)
                {
                    Console.WriteLine(rect.GetArea());
                    Console.WriteLine("Некорректная площадь!");
                }
            }
        }
    }

    /// Проблему, с который связан принцип Лисков, наглядно можно продемонстрировать 
    /// на примере двух классов Прямоугольника и Квадрата. Пусть они будут выглядеть 
    /// следующим образом:

    /// <summary>
    /// Прямоугольник
    /// </summary>
    class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    /// <summary>
    /// Квадрат
    /// Как правило, квадрат представляют как частный случай прямоугольника - те же прямые углы, 
    /// четыре стороны, только ширина обязательно равна высоте. 
    /// Поэтому в классе Квадрат у одного свойства устанавливаются сразу и ширина, и высота:
    /// </summary>
    class Square : Rectangle
    {
        public override int Width
        {
            get
            {
                return base.Width;
            }

            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get
            {
                return base.Height;
            }

            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }

}
