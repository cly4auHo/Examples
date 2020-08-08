using System;


/// <summary>
/// Делегат Predicate<T>, как правило, используется для сравнения, сопоставления 
/// некоторого объекта T определенному условию. В качестве выходного результата 
/// возвращается значение true, если условие соблюдено, и false, если не соблюдено:
/// </summary>
namespace _023__Predicate
{
    class Program
    {
        static void Main()
        {
            DateTime dateTime = new DateTime(2020, 1, 1);

            // Predicate<DateTime> predicate = new Predicate<DateTime>(DateComparison);
            Predicate<DateTime> predicate = DateComparison;

            bool result = predicate.Invoke(dateTime);
            // bool result = predicate(dateTime);

            Console.WriteLine(result);

            Predicate<int> isPositive = delegate (int x) { return x > 0; };

            Console.WriteLine(isPositive(10));
            Console.WriteLine(isPositive(-1));

            Console.ReadKey();
        }

        public static bool DateComparison(DateTime currentDate)
        {
            return DateTime.Now > currentDate;
        }
    }
}
