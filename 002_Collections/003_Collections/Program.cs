using System;
using System.Collections;

/// <summary>
///  Класс ArrayList 
///  Метод Sort
/// </summary>
namespace _003_Collections
{
    class Program
    {
        static void Main()
        {
            // Создание коллекции ArrayList с именем arrayList
            ArrayList arrayList = new ArrayList();

            // Add - добавляет объект в коллекцию arrayList
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(1);

            // Метод Sort() - сортирует коллекцию
            arrayList.Sort();

            //Перебор элементов коллекции
            foreach (int item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
