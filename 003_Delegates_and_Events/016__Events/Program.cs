using System;

/// <summary>
/// События
/// События сигнализируют системе о том, что произошло определенное действие.
/// И если нам надо отследить эти действия, то как раз мы можем применять события.
/// </summary>
namespace _016__Events
{
    public delegate void EventDelegate();
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            // Присоединение обработчиков событий. (Подписка на событие)
            instance.myEvent += new EventDelegate(Handler1);
            // Техника предположения делагатов
            instance.myEvent += Handler2;

            // Метод который вызывает событие.
            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Открепляем Handler2().
            instance.myEvent = null;

            //instance.InvokeEvent();

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

    /// <summary>
    /// Класс MyClass 
    /// </summary>
    public class MyClass
    {
        /// <summary>
        /// Событые 
        /// </summary>
        public EventDelegate myEvent = null;

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }
}
