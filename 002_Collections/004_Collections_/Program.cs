using System;
using System.Collections.Generic;

/// <summary>
/// Класс List<T>
/// Класс List<T> из пространства имен System.Collections.Generic 
/// представляет простейший список однотипных объектов.
/// </summary>
namespace _004_Collections_
{
    class Program
    {
        static void Main()
        {
            // Создание коллекции List с именем list
            List<string> list = new List<string>();

            // Добавление в набор одиночных элементов используя метод Add.
            string @string = "Hello";
            list.Add(@string);
            list.Add("hi");
            list.Add("50");

            // Создаем массив типа string, инициализируем данный массив используя блок инициализатора.
            string[] anArray = new[] { "more", "or", "less" };

            // Добавление в набор групп элементов используя метод AddRange.
            list.AddRange(anArray);

            // Вставка элементов в заданное положение используя метод Insert.
            list.Insert(3, "Hey All");

            // Вставка элементов в заданное положение используя метод InsertRange.
            string[] moreString = new[] { "goodnight", "see ya" };
            list.InsertRange(4, moreString);

            // Вставка элементов в заданное положение используя индексатор.
            // (!) При использовании индексатора элемент не вставляется в набор, а перезаписывается прежний объект, бывший в этом элементе.
            list[3] = "Hey All 2";

            // Добавление в набор одиночных элементов используя метод Add.
            list.Add("Hello");
            // Remove - Удаляет первое вхождение указанного объекта из коллекции.
            list.Remove("Hello");

            // Удаление из набора одиночных элементов с заданным индексом используя метод RemoveAt.
            // RemoveAt - Удаляет элемент списка коллекции с указанным индексом.
            list.RemoveAt(0);

            // Удаление из набора, группы элементов с заданным диапазоном используя метод RemoveRange.
            list.RemoveRange(0, 4);

            // Другие методы для добавления и удаления элементов набора - Contains, IndexOf, Clear.
            string myString = "My String";

            // Contains - Определяет, входит ли элемент в коллекцию
            if (list.Contains(myString))
            {
                // Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс
                // первого вхождения, найденного в пределах всего списка List.
                int index = list.IndexOf(myString);

                // Удаляет элемент списка List с указанным индексом.
                list.RemoveAt(index);
            }
            else
            {
                //  Удаляет все элементы из коллекции
                list.Clear();
            }

            /*Аналогично можно делать все действие с коллекцией, если закрыть ее типом int, 
              или другим типом данных */

            List<int> listInt = new List<int>();

            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.Add(4);
            listInt.Add(5);

            // Задержка.
            Console.ReadKey();
        }
    }
}
