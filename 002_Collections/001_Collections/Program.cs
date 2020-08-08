using System;
using System.Collections;

/// <summary>
/// Класс ArrayList представляет коллекцию объектов. И если надо 
/// сохранить вместе разнотипные объекты - строки, числа и т.д., 
/// то данный класс подходит для этого.
/// </summary>
namespace _001_Collections
{
    class Program
    {
        static void Main()
        {
            // Создание коллекции ArrayList с именем arrayList
            ArrayList arrayList = new ArrayList();

            // Добавление в набор одиночных элементов используя метод Add.
            string @string = "Hello";
            arrayList.Add(@string);
            arrayList.Add("hi");
            arrayList.Add(50);
            arrayList.Add(new object());

            // Добавление в набор групп элементов используя блок инициализатра.
            var anArray = new[] { "more", "or", "less" };

            // Добавление в набор групп элементов используя метод AddRange.
            arrayList.AddRange(anArray);

            // Создаем массив типа object, размерностью в 2 элемента;
            object[] anotherArray = new object[2];
           
            // Элементу по индексу 0 присваиваем значение new object()
            anotherArray[0] = new object();

            // Элементу по индексу 1 присваиваем значение new ArrayList()
            anotherArray[1] = new ArrayList();
            
            // Или упрощенная запись
            // Создаем массив типа object, инициализируем данный массив используя блок инициализатора.
            //object[] anotherArray = new[] { new object(), new ArrayList() };

            // Добавление в набор групп элементов используя метод AddRange.
            arrayList.AddRange(anotherArray);

            // Выводим количество элементов коллекции
            Console.WriteLine(arrayList.Count);

            // Вставка элементов в заданное положение используя метод Insert.
            arrayList.Insert(3, "Hey All");

            // Выводим количество элементов коллекции
            Console.WriteLine(arrayList.Count);

            object[] moreString = new[] { "goodnight", "see ya" };

            // Вставка элементов в заданное положение используя метод InsertRange.
            arrayList.InsertRange(4, moreString);

            // Вставка элементов в заданное положение используя индексатор.
            // (!) При использовании индексатора элемент не вставляется в набор, а перезаписывается прежний объект, бывший в этом элементе.
            arrayList[3] = "Hey All 2";

            // Удаление из набора одиночных элементов используя метод Remove.
            arrayList.Add("Hello");
            arrayList.Remove("Hello");

            // Удаление из набора одиночных элементов с заданным индексом используя метод RemoveAt.
            arrayList.RemoveAt(0);

            // Удаление из набора, группы элементов с заданным диапазоном используя метод RemoveRange.
            arrayList.RemoveRange(0, 4);

            // Другие методы для добавления и удаления элементов набора - Contains, IndexOf, Clear.
            
            string myString = "My String";

            // Contains - Определяет, входит ли элемент в коллекцию
            if (arrayList.Contains(myString))
            {
                // IndexOf - Осуществляет поиск указанного объекта и возвращает отсчитываемый
                // от нуля индекс первого вхождения в коллекцию.
                int index = arrayList.IndexOf(myString);
                // RemoveAt - Удаляет элемент списка
                arrayList.RemoveAt(index);
            }
            else
            {
                // Удаляет все элементы из коллекции
                arrayList.Clear();
            }

            // Задержка
            Console.ReadKey();
        }
    }
}
