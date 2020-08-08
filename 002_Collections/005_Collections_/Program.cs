using System;
using System.Collections.Generic;

/// <summary>
/// Класс List<T>
/// Перебор элементов коллекции List<T>
/// </summary>
namespace _005_Collections_
{
    class Program
    {
        static void Main()
        {
            // Создание коллекции List с именем list
            List<int> list = new List<int>();

            // Добавление в набор одиночных элементов используя метод Add.
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // 1.Перебор можно осуществить с помощью цикла for
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // Оттеняем вывод
            Console.WriteLine(new string('-', 10));

            // 2.Перебор можно осуществить с помощью цикла foreach
            // list - коллекция
            // item - переменная итерации (перебора)
            // Поочередно извлекаем элементы из коллекции list и помещаем их в переменную итерации item
            foreach (int item in list)
            {
                // Выводим значение переменной интерации на консоль
                Console.WriteLine(item);
            }

            // Оттеняем вывод
            Console.WriteLine(new string('-', 10));

            try
            {
                // Никогда не делай этого!, так как измененение коллекции
                // вовремя выполнения повлечет за собою ошибку!
                foreach (int item in list)
                {
                    // Никогда не делай этого!, так как измененение коллекции
                    // вовремя выполнения повлечет за собою ошибку!
                    list.Remove(item);

                    list.Add(10);

                    Console.WriteLine(item);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
            // Задержка.
            Console.ReadKey();
        }
    }
}
