using System;
using System.Collections;

namespace _011_Collections_UserCollection
{
    /// <summary>
    /// Реализация пользовательской коллекции
    /// </summary>
    class UserCollection : IEnumerable, IEnumerator
    {
        public Element[] elementsArray = null;
        
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public UserCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
            elementsArray[2] = new Element("C", 3, 30);
            elementsArray[3] = new Element("D", 4, 40);
        }

        /// <summary>
        /// Указатель текущей позиции элемента в массиве.
        /// </summary>
        int position = -1;

        /***********Реализация интерфейса IEnumerator.***********/
        /// <summary>
        /// Передвинуть внутренний указатель (position) на одну позицию.
        /// </summary>
        public bool MoveNext()
        {
            //Если позиция елемента, лежит в пределах длины массива
            if (position < elementsArray.Length - 1)
            {
                //тогда увеличиваем position на 1.
                position++;
                //Возвращаем true
                return true;
            }
            //Инче, возвращаем false
            else
            {
                //Reset();
                return false;
            }
        }

        /// <summary>
        /// Сбросить указатель (position) перед началом набора.
        /// </summary>
        public void Reset()
        {
            position = -1;
        }

        /// <summary>
        /// Получить текущий элемент набора. 
        /// </summary>
        public object Current
        {
            get { return elementsArray[position]; }
        }

        /***********Реализация интерфейса IEnumerable.***********/
        IEnumerator IEnumerable.GetEnumerator()
        {
            //Привести текущий объект к интерфейсному типу IEnumerator
            return this as IEnumerator;
        }
    }
}
