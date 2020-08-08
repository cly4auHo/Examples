using System;

/// <summary>
/// Еще одним распространенным делегатом является Func. 
/// Он возвращает результат действия и может принимать параметры. 
/// Он также имеет различные формы: от Func<out T>(), 
/// где T - тип возвращаемого значения, до Func<in T1, in T2,...in T16, 
/// out TResult>(), то есть может принимать до 16 параметров.
/// </summary>
namespace _024_Func
{
    class Program
    {
        static void Main()
        {
            Func<string> func = new Func<string>(GetGreeting);
            
            string greeting = func.Invoke();

            Console.WriteLine(greeting);

            Console.ReadKey();
        }

        public static string GetGreeting()
        {
            return "Hello World";
        }
    }
}
