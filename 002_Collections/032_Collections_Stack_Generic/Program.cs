using System;
using System.Collections.Generic;

/// <summary>
/// Класс Stack представляет коллекцию, которая использует алгоритм LIFO 
/// ("последний вошел - первый вышел"). При такой организации каждый следующий 
/// добавленный элемент помещается поверх предыдущего.Извлечение из коллекции 
/// происходит в обратном порядке - извлекается тот элемент, который находится 
/// выше всех в стеке.
/// </summary>
namespace _032_Collections_Stack_Generic
{
    class Program
    {
        static void Main()
        {
            // Представляет коллекцию переменного размера экземпляров одинакового заданного
            // типа, обслуживаемую по принципу "последним пришел - первым вышел" (LIFO).
            Stack<string> stack = new Stack<string>();

            // Вставляет объект как верхний элемент стека
            stack.Push("1");

            // Удаляет и возвращает объект в верхней части 
            string serialNumber = stack.Pop();

            // Выводим значение переменной serialNumber на консоль
            Console.WriteLine(serialNumber);

            Console.WriteLine(new string('-', 10));

            // Вставляет объект как верхний элемент стека
            stack.Push("1-element");
            stack.Push("2-element");

            // Перебор элементов коллекции
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
