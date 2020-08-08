using System;
using System.Collections;

/// <summary>
/// Класс ArrayList 
/// Перебор элементов коллекции ArrayList
/// </summary>
namespace _002_Collections
{
    class Program
    {
        static void Main()
        {
            // Создание коллекции ArrayList с именем arrayList
            ArrayList arrayList = new ArrayList();

            // Add - добавляет объект в коллекцию arrayList
            arrayList.Add("Hello");
            arrayList.Add("Goodbye");

            // 1.Перебор можно осуществить с помощью цикла for
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            // Оттеняем вывод
            Console.WriteLine(new string('-', 10));

            // 2.Перебор можно осуществить с помощью цикла foreach
            foreach (string item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Внимание !
            foreach (string item in arrayList)
            {
                // Никогда не делай этого!, так как измененение коллекции
                // вовремя выполнения повлечет за собою ошибку!
                // list.Remove(item);
                // list.Add("Hello world!");
                Console.WriteLine(item);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
