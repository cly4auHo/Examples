using System;
using System.Collections;

/// <summary>
/// Класс Stack представляет коллекцию, которая использует алгоритм LIFO 
/// ("последний вошел - первый вышел"). При такой организации каждый следующий 
/// добавленный элемент помещается поверх предыдущего.Извлечение из коллекции 
/// происходит в обратном порядке - извлекается тот элемент, который находится 
/// выше всех в стеке.
/// </summary>
namespace _021_Collections
{
    class Program
    {
        static void Main()
        {
            // Stack - Представляет простую неуниверсальную коллекцию объектов, 
            // работающую по принципу «последним поступил — первым обслужен».
            Stack stack = new Stack();

            // Push() - добавляет элемент в конец стека.
            stack.Push("An item");

            Console.WriteLine(string.Format(@"Количество елементов в коллекции = {0}", stack.Count));
            Console.WriteLine(Environment.NewLine);

           // Pop() - возвращает первый элемент стека, удаляя его.
            Console.WriteLine(stack.Pop());

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(string.Format(@"Количество елементов в коллекции = {0}", stack.Count));

            // Задержка.
            Console.ReadKey();
        }
    }
}
