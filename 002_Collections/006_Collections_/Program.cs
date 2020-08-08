using System;
using System.Collections.Generic;

/// <summary>
/// Класс List<T>
/// Метод Sort
/// </summary>
namespace _006_Collections_
{
    class Program
    {
        static void Main()
        {
            // Создание коллекции List с именем list
            List<int> list = new List<int>();

            // Добавление в набор одиночных элементов используя метод Add.
            list.Add(2);
            list.Add(3);
            list.Add(1);

            // Метод Sort() - сортирует коллекцию
            list.Sort();

            //Перебор элементов коллекции
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
