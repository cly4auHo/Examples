using System;

/// <summary>
/// Делегат
/// Рекурсия в лямбда операторах.
/// </summary>
namespace _015_Delegates
{
    class Program
    {
        delegate void MyDelegate(int argument);
        static void Main()
        {
            // Требуется обязательно присвоить null.
            MyDelegate my = null;

            my = (int i) =>
            {
                i--;
                Console.WriteLine("Begin {0}", i);

                if (i > 0)
                {
                    my(i);
                }

                Console.WriteLine("End {0}", i);
            };

            my(3);

            Console.WriteLine("");

            RegularRecursion(3);

            // Задержка.
            Console.ReadKey();
        }

        public static void RegularRecursion(int i)
        {
            i--;
            Console.WriteLine("Begin {0}", i);
            if (i > 0)
            {
                RegularRecursion(i);
            }

            Console.WriteLine("End {0}", i);
        }
    }
}

