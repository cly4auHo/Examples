using System;
using System.Collections;

/// <summary>
/// Класс Queue представляет обычную очередь, работающую по алгоритму FIFO ("первый вошел - первый вышел").
/// </summary>
namespace _019_Collections
{
    class Program
    {
        static void Main()
        {
            // Представляет коллекцию объектов, основанную на принципе «первым поступил — первым
            // обслужен
            Queue queue = new Queue();

            // Enqueue() - добавляет элемент в конец очереди.
            queue.Enqueue("An item");

            Console.WriteLine(string.Format(@"Количество елементов в коллекции = {0}", queue.Count));

            // Dequeue() - возвращает первый элемент очереди, удаляя его.
            Console.WriteLine(queue.Dequeue());

            // Задержка.
            Console.ReadKey();
        }
    }
}
