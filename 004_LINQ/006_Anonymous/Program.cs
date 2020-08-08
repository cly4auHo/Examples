using System;

/// <summary>
///  Анонимные типы (инициализаторы с проекцией)
///  можно использовать инициализаторы с проекцией (projection initializers), 
///  когда мы можем передать в инициализатор некоторые идиентификаторы, 
///  имена которых будут использоваться как названия свойств:
/// </summary>
namespace _006_Anonymous
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса User
            User user = new User { Name = "Alex", Surname = "Glembitskij" };

            //Переменная возраст
            int Age = 27;

            // инициализатор с проекцией
            var anonymousType = new { user.Name, user.Surname, Age };

            Console.WriteLine("Name = {0}, Surname = {1}, Age = {2}",
               anonymousType.Name, anonymousType.Surname, anonymousType.Age);

            Console.WriteLine(new string('-', 10));

            //Получаем тип анонимного типа
            Type type = anonymousType.GetType();

            //Выводим информацию на консоль о типе анонимного типа
            Console.WriteLine(type.Name.ToString());

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Пользователь 
    /// </summary>
    class User
    {
        /// <summary>
        /// Имя 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия 
        /// </summary>
        public string Surname { get; set; }
    }
}
