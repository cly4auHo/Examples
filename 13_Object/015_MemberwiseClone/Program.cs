using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _015_MemberwiseClone
{
    class Program
    {
        static void Main()
        {
            Stopwatch timer = new Stopwatch();

            // замер время построения оригинала
            timer.Start();
            MyClass original = new MyClass();
            timer.Stop();

            Console.WriteLine(string.Format(@"Время построения оригинала {0}", timer.Elapsed.Ticks));

            timer.Reset();

            timer.Start();
            MyClass clone = original.Clone() as MyClass;
            timer.Stop();

            Console.WriteLine(string.Format(@"Время построения клона {0}", timer.Elapsed.Ticks));

            Console.ReadKey();
        }
    }
    class MyClass : ICloneable
    {
        int a;
        int b;

        public MyClass()
        {
            Thread.Sleep(1000);
            a = new Random().Next(1, 100);
            Thread.Sleep(1000);
            b = new Random().Next(1, 100);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
