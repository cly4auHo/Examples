using System;

/// <summary>
/// События
/// События сигнализируют системе о том, что произошло определенное действие.
/// И если нам надо отследить эти действия, то как раз мы можем применять события.
/// </summary>
namespace _017__Events
{
    public delegate void EventDelegate();

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            // Подписка на событие.
            instance.MyEvent += Handler1;
            instance.MyEvent += Handler2;

            // Метод который вызывает событие.
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Открепляем Handler2().
            instance.MyEvent -= new EventDelegate(Handler2);
            instance.InvokeEvent();

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Метод обработчики события Handler1.
        /// </summary>
        static private void Handler1()
        {
            Console.WriteLine("Обработчик события 1");
        }

        /// <summary>
        /// Метод обработчики события Handler2.
        /// </summary>
        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }
    }

    public class MyClass
    {
        EventDelegate myEvent = null;

        // Реализация методов доступа add и remove для события.
        public event EventDelegate MyEvent
        {
            add
            {
                myEvent += value;
            }
            remove
            {
                myEvent -= value;
            }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }
}
