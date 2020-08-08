using System;

/// <summary>
/// Анонимные типы 
/// Это новая возможность C# 3.0. Она позволяет создавать тип/класс "на лету" во время компиляции.
/// Анонимные типы позволяют создать объект с некоторым набором свойств без определения класса. 
/// Анонимный тип определяется с помощью ключевого слова var и инициализатора объектов.
/// Для исполняющей среды CLR анонимные типы будут также, как и классы, представлять ссылочный тип.
/// </summary>
namespace _001_Anonymous
{
    class Program
    {
        static void Main()
        {
            Teacher teacher = new Teacher() 
                { 
                    Name = "Alex", 
                    Surname = "Glembitskij", 
                    Age = 27 
                };

            Console.WriteLine("Name = {0}, Surname = {1}, Age = {2}",
                teacher.Name, teacher.Surname, teacher.Age);

            Console.WriteLine(new string('-', 10));

            /*Тоже самое, но с помощью анонимных типов*/

            //anonymousType - объект анонимного типа, у которого определены три свойства Name, Surname и Age.
            var anonymousType = new { Name = "Alex", Surname = "Glembitskij", Age = 27 };

            Console.WriteLine("Name = {0}, Surname = {1}, Age = {2}",
               anonymousType.Name, anonymousType.Surname, anonymousType.Age);

            Console.WriteLine(new string('-', 10));

            //Получаем тип анонимного типа
            Type type = anonymousType.GetType();

            //Выводим информацию на консоль о типе анонимного типа
            Console.WriteLine(type.ToString());
            Console.WriteLine(teacher.GetType().Name);
           
            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс Преподаватель 
    /// </summary>
    class Teacher
    {
        /// <summary>
        /// Имя преподавателя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия преподавателя
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }
    }
}
