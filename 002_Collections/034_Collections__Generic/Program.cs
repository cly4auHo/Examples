using System;
using System.Collections.Generic;

/// <summary>
/// Класс LinkedList<T> представляет двухсвязный список, в котором каждый 
/// элемент хранит ссылку одновременно на следующий и на предыдущий элемент.
/// Если в простом списке List<T> каждый элемент представляет объект типа T, 
/// то в LinkedList<T> каждый узел представляет объект класса LinkedListNode<T>.
/// </summary>
namespace _034_Collections__Generic
{
    class Program
    {
        static void Main()
        {
            // LinkedList - Представляет двунаправленный список.
            // T - Указывает тип элементов связанного списка.
            LinkedList<string> links = new LinkedList<string>();

            //LinkedListNode - Представляет узел в System.Collections.Generic.LinkedList
            // AddFirst - Добавляет новый узел, содержащий указанное значение в начале
            LinkedListNode<string> first = links.AddFirst("First");
            // AddLast - Добавляет новый узел, содержащий указанное значение в конце
            LinkedListNode<string> last = links.AddLast("Last");
            // AddAfter - Добавляет новый узел, содержащий указанное значение после указанного существующего
            LinkedListNode<string> afterlast = links.AddAfter(last, "After last");

            // AddBefore - Добавляет новый узел, содержащий указанное значение перед указанным узлом
            LinkedListNode<string> second = links.AddBefore(last, "Second");

            links.AddAfter(second, "Third");

            foreach (string str in links)
            {
                Console.WriteLine(str);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
