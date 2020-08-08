using System.Collections.Generic;
using System;

/// <summary>
/// Класс Queue<T> - обобщенный представляет обычную очередь, работающую по алгоритму FIFO ("первый вошел - первый вышел").
/// </summary>
namespace _031_Collections_Queue_Generic
{
    class Program
    {
        static void Main()
        {
            // Представляет коллекцию объектов, основанную на принципе «первым поступил — первым
            // обслужен, закрытый указателем места заполнения типа - string
            Queue<string> queue = new Queue<string>();

            // Добавляет объект в конец очереди 
            queue.Enqueue("Hello");

            // Удаляет объект из начала очереди 
            string queued = queue.Dequeue();

            // Выводим значение переменной queued на консоль
            Console.WriteLine(queued);

            Console.WriteLine(new string('-', 10));

            // Добавляет объект в конец очереди 
            queue.Enqueue("1-element");
            queue.Enqueue("2-element");

            // Перебор элементов коллекции
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
