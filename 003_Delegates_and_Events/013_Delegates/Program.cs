using System;

/// <summary>
/// Делегат
/// </summary>
namespace _013_Delegates
{
    class Program
    {
        delegate MyDelegate Functional(MyDelegate delegate1, MyDelegate delegate2);

        delegate string MyDelegate();
        static void Main()
        {
            MyDelegate myDelegate1 = () => { return "Hellow"; };

            MyDelegate myDelegate2 = () => { return " World"; };

            /*Functional functional = 
                delegate(MyDelegate delegate1, MyDelegate delegate2)
                { 
                    return delegate () { return delegate1.Invoke() + delegate2.Invoke(); }; 
                };*/

            /*Functional functional = 
                delegate(MyDelegate d1, MyDelegate d2) 
                    { 
                        return () => d1.Invoke() + d2.Invoke(); 
                    };*/

            Functional functional = (d1, d2) => () => d1() + d2();

            string result = functional.Invoke(myDelegate1, myDelegate2).Invoke();

            Console.WriteLine(result);

            //Задержка
            Console.ReadKey();
        }
    }
}
