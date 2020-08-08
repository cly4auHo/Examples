using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Итератор по сути представляет блок кода, 
/// который использует оператор yield для перебора набора значений.
/// Реализация оператор yield (14 -й пример, yield break)(под рефлектором)
/// </summary>
namespace _017_Collections_yield
{
    class Program
    {
        static void Main()
        {
            foreach (string element in UserCollection.Power())
            {
                Console.WriteLine(element);
            }

            // Задержка. 
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Пользовательская коллекция - UserCollection
    /// </summary>
    class UserCollection
    {
        /// <summary>
        /// Метод - Power - возвращает интерфейсный тип IEnumerable
        /// </summary>
        public static IEnumerable Power()
        {
            return new ClassPower(-2);
            //yield return "Hello world!";
        }

        /// <summary>
        /// Реализация оператора yield
        /// Сгенироровался Nested - ClassPower
        /// Реализует интерфейсы IEnumerable<object>, IEnumerator<object>, 
        /// IEnumerator, IDisposable
        /// </summary>
        private sealed class ClassPower : IEnumerable<object>, IEnumerator<object>, IEnumerator, IDisposable
        {
            // Поля.
            private int state;
            private object current;
            private int initialThreadId;

            /// <summary>
            /// Конструктор класс UserCollection
            /// </summary>
            public ClassPower(int state)
            {
                this.state = state;
                // Доступ к коллекции, как к разделяемому ресурсу 
                // ManagedThreadId - Возвращает уникальный идентификатор текущего потока.
                this.initialThreadId = Thread.CurrentThread.ManagedThreadId;
            }

            /***** Реализая интерфейса IEnumerator<object> *****/

            /// <summary>
            ///  IEnumerator<object> (IEnumerator)
            ///  Так в Рефлекторе
            /// </summary>
            public bool MoveNext()
            {
                // Безусовно возвращает false
                return false;
            }

            /// <summary>
            ///  Реализация IEnumerator<object> 
            /// </summary>
            object IEnumerator<object>.Current
            {
                get
                {
                    return this.current;
                }
            }

            /// <summary>
            ///  Реализация IEnumerator
            /// </summary>
            object IEnumerator.Current
            {
                get
                {
                    return this.current;
                }
            }

            /// <summary>
            ///  IEnumerator<object> (IDisposable)
            /// </summary>
            public void Dispose() { }

            /// <summary>
            ///  IEnumerator<object> (IEnumerator)
            /// </summary>
            public void Reset() { }
            /************************************************/

            /***** Реализая интерфейса IEnumerable<object> *****/
            /// <summary>
            /// IEnumerable<object>
            /// </summary>
            public IEnumerator<object> GetEnumerator()
            {
                if ((Thread.CurrentThread.ManagedThreadId == this.initialThreadId) && (this.state == -2))
                {
                    this.state = 0;
                    return this;
                }

                return new UserCollection.ClassPower(0);
            }

            /// <summary>
            ///  IEnumerable<object>
            /// </summary>
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (this as IEnumerable<object>).GetEnumerator();
            }
        }
    }
}
