using System;

/// <summary>
/// Анонимные типы
/// Вложенность анонимных типов (анонимные типы в анонимных типах.)
/// </summary>
namespace _002_Anonymous
{
    class Program
    {
        static void Main()
        {
            // anonymousType - объект анонимного типа, у которого определены три свойства 
            // Name, Surname и Age, Information - объект анонимного типа вложенный в обект 
            //anonymousType, у которого определенны два свойства Number и Position
            var anonymousType = new
            {
                Name = "Alex", /*Имя*/
                Surname = "Glembitskij", /*Фамилия*/
                Age = 27,  /*Возраст*/
                Information = new { Number = 123, Position = "Teacher" } /*Информация*/
            };

            //Внешний тип
            Type externalType = anonymousType.GetType();
            Console.WriteLine(externalType.Name);

            //Вложенный тип
            Type nestedType = anonymousType.Information.GetType();
            Console.WriteLine(nestedType.Name);

            Console.WriteLine(new string('-', 10));

            //Вывод данных
            Console.WriteLine("Name = {0}, Surname = {1}, Age = {2}, Number = {3}, Position = {4}",
                anonymousType.Name, anonymousType.Age, anonymousType.Surname,
                anonymousType.Information.Number, anonymousType.Information.Position);

            // Задержка.
            Console.ReadKey();
        }
    }
}
