using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Принцип открытости/закрытости (Open/Closed Principle) можно сформулировать так:
/// Сущности программы должны быть открыты для расширения, но закрыты для изменения.
/// Суть этого принципа состоит в том, что система должна быть построена таким образом, 
/// что все ее последующие изменения должны быть реализованы с помощью добавления 
/// нового кода, а не изменения уже существующего.
/// </summary>
namespace _02_Open_Closed_Principle
{
    class Program
    {
        static void Main()
        {
            // С помощью метода MakeDinner любой объект данного класса сможет 
            // сделать картофельного пюре:

            Cook bob = new Cook("Bob");
            bob.MakeDinner();

            /*Однако одного умения готовить картофельное пюре для повара вряд ли достаточно. 
             Хотелось бы, чтобы повар мог приготовить еще что-то. И в этом случае мы подходим 
             к необходимости изменения функционала класса, а именно метода MakeDinner. 
             Но в соответствии с рассматриваемым нами принципом классы должны быть 
             открыты для расширения, но закрыты для изменения. То есть, нам надо сделать 
             класс Cook отрытым для расширения, но при этом не изменять.*/

            Console.WriteLine(new string('-', 30));

            CookRefactoring bobRefactoring = new CookRefactoring("Bob");
            bobRefactoring.MakeDinner(new PotatoMeal());
            Console.WriteLine();
            bobRefactoring.MakeDinner(new SaladMeal());

            /*Теперь класс Cook закрыт от изменений, зато мы можем легко расширить 
              его функциональность, определив дополнительные реализации интерфейса IMeal.*/

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Повар
    /// </summary>
    class Cook
    {
        public string Name { get; set; }
        public Cook(string name)
        {
            this.Name = name;
        }

        public void MakeDinner()
        {
            Console.WriteLine("Чистим картошку");
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }
    }

    class CookRefactoring
    {
        public string Name { get; set; }

        public CookRefactoring(string name)
        {
            this.Name = name;
        }

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }

    /// <summary>
    /// Интерфейс Еда
    /// </summary>
    interface IMeal
    {
        void Make();
    }

    /// <summary>
    /// Картофельное пюре
    /// </summary>
    class PotatoMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Чистим картошку");
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }
    }

    /// <summary>
    /// Салат
    /// </summary>
    class SaladMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы");
            Console.WriteLine("Посыпаем зеленью, солью и специями");
            Console.WriteLine("Поливаем подсолнечным маслом");
            Console.WriteLine("Салат готов");
        }
    }
}
