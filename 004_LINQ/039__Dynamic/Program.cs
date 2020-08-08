using System;

/// <summary>
/// Динамические типы данных. 
/// События
/// </summary>
namespace _039__Dynamic
{
    delegate dynamic MyDelegate(dynamic sender, dynamic e);
    class Program
    {
        static void Main()
        {
            dynamic my = new MyClass();
            my.MyEvent += new MyDelegate(Handler);
            //Console.WriteLine();
            my.Method("user", "mouse");

            // Задержка.
            Console.ReadKey();
        }
        
        static dynamic Handler(dynamic sender, dynamic e)
        {
            Console.WriteLine("sender = {0}, e = {1}", sender, e);
            return default(dynamic);
        }
    }

    class MyClass
    {
        dynamic myEvent;

        public event MyDelegate MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public dynamic Method(dynamic sender, dynamic e)
        {
            myEvent.Invoke(sender, e);
            return default(dynamic);
        }
    }
}
