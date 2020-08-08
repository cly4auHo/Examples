using System;
using System.Collections.Generic;

namespace _36_Covariance
{
    class Program
    {
        static void Main()
        {
            List<BaseClass> listBaseClasses = new List<BaseClass>();

            listBaseClasses.Add(new BaseClass() { Name = "item 1" });
            listBaseClasses.Add(new BaseClass() { Name = "item 2" });
            listBaseClasses.Add(new BaseClass() { Name = "item 3" });

            List<DerivedClass> listDerivedClasses = new List<DerivedClass>();

            listDerivedClasses.Add(new DerivedClass() { Name = "item 1" });
            listDerivedClasses.Add(new DerivedClass() { Name = "item 2" });
            listDerivedClasses.Add(new DerivedClass() { Name = "item 3" });

            listBaseClasses.Method();

            Console.WriteLine(new string('-', 30));

            listDerivedClasses.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Статический класс MyClass
    /// </summary>
    public static class MyClass
    {
        /// <summary>
        /// Метод расширения 
        /// </summary>
        public static void Method(this IEnumerable<BaseClass> baseClasses)
        {
            foreach (var item in baseClasses)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
    public class BaseClass
    {
        public string Name { get; set; }
    }

    public class DerivedClass : BaseClass { }
}
