using System;

/// <summary>
/// Делегат
/// </summary>
namespace _012_Delegates
{
    delegate Delegate3 Functional(Delegate1 delegate1, Delegate2 delegate2);

    delegate string Delegate1();
    delegate string Delegate2();
    delegate string Delegate3();
    class Program
    {
        static void Main()
        {
            Functional functional = new Functional(Method);

            Delegate1 delegate1 = new Delegate1(Method1);
            Delegate2 delegate2 = new Delegate2(Method2);

            Delegate3 delegate3 = functional.Invoke(delegate1, delegate2);
            
            //или 
            //Delegate3 delegate3 = functional.Invoke(new Delegate1(Method1), new Delegate2(Method2));

            Console.WriteLine(delegate3.Invoke());

            Console.WriteLine(new string('-', 10));

            Console.WriteLine(delegate3());

            Console.ReadKey();
        }
        public static Delegate3 Method(Delegate1 delegate1, Delegate2 delegate2)
        {
            return () => { return delegate1.Invoke() + delegate2.Invoke(); };
        }

        public static string Method1() { return "Hello "; }
        public static string Method2() { return "world!"; }
    }
}
