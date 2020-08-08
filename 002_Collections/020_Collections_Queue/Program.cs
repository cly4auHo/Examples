using System;
using System.Collections;

/// <summary>
/// Класс Queue<T> представляет обычную очередь, работающую по алгоритму FIFO ("первый вошел - первый вышел").
/// </summary>
namespace _020_Collections_Queue
{
    class Program
    {
        static void Main()
        {
            // Представляет коллекцию объектов, основанную на принципе «первым поступил — первым
            // обслужен
            Queue queue = new Queue();

            // Добавление в набор одиночных элементов используя метод Enqueue.
            // Enqueue - Добавляет объект в конец очереди
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            Console.WriteLine(string.Format(@"Количество елементов в коллекции = {0}", queue.Count));

            Console.WriteLine(new string('-', 10));

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 10));

            // Peek() - возвращает первый элемент из очереди не удаляя его.
            object element = queue.Peek();

            //Вывод 1-го элемента очереди на консоль.
            Console.WriteLine(element as string);

            Console.WriteLine(new string('-', 10));

            //Проверка, если 1-й елемент ето строка, тогдв
            if (element is string)
            {
                // Dequeue() - возвращает первый элемент очереди, удаляя его.
                Console.WriteLine(queue.Dequeue());
            }

            // Count - возвращает количество элементов в очереди.
            while (queue.Count > 0)
            {
                // Dequeue() - возвращает первый элемент очереди, удаляя его.
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine(new string('-', 10));

            Console.WriteLine(string.Format(@"Количество елементов в коллекции = {0}", queue.Count));

            // Задержка.
            Console.ReadKey();
        }
    }
}
