using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Класс Stack представляет коллекцию, которая использует алгоритм LIFO 
/// ("последний вошел - первый вышел"). При такой организации каждый следующий 
/// добавленный элемент помещается поверх предыдущего.Извлечение из коллекции 
/// происходит в обратном порядке - извлекается тот элемент, который находится 
/// выше всех в стеке.
/// </summary>
namespace _022_Collections
{
    class Program
    {
        static void Main()
        {
            // Stack - Представляет простую неуниверсальную коллекцию объектов, 
            // работающую по принципу «последним поступил — первым обслужен».
            Stack stack = new Stack();

            // stack - Вставляет объект как верхний элемент стека System.Collections.Stack.
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            // Peek() - возвращает элемент с вершины стека, не удаляя его.
            if (stack.Peek() is string)
            {
                // Pop() - возвращает первый элемент стека, удаляя его.
                Console.WriteLine(stack.Pop());
            }

            // Count - возвращает количество элементов в стеке.
            while (stack.Count > 0)
            {
                // Pop() - возвращает первый элемент стека, удаляя его.
                Console.WriteLine(stack.Pop());
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
