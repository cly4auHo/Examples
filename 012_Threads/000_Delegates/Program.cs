using System;

/// <summary>
/// Делегаты
/// </summary>
namespace _000_Delegates
{
    class Program
    {
        static void Main()
        {
            WorkAction();

            Console.WriteLine(new string('-', 30));

            WorkPredicate();

            //Задержка
            Console.ReadKey();
        }

        #region Action
        public static void WorkAction()
        {
            //Делегат Action является обобщенным, принимает параметры и возвращает значение void:

            Action<int, int> operation = Operation;
            //operation.Invoke(10, 6);
            operation(10, 6);
        }

        static void Operation(int x1, int x2)
        {
            int res = x1 + x2;

            Console.WriteLine(@"{0} + {1} = {2}", x1, x2, res);
        }
        #endregion

        #region Predicate
        public static void WorkPredicate()
        {
            int number = 5;

            Func<int, int> retFunc = Factorial;
            int n1 = retFunc(number);
            Console.WriteLine("Факториал {0}! = {1}", number, n1);
        }

        static int Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion
    }
}
