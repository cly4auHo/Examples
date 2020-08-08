using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// метод Join()
/// </summary>
namespace _014_LINQ
{
    class Program
    {
        static void Main()
        {
            List<Team> teams = new List<Team>()
            {
                new Team { Name = "Бавария", Country ="Германия" },
                new Team { Name = "Барселона", Country ="Испания" }
            };

            List<Player> players = new List<Player>()
            {
                new Player {Name="Месси", Team="Барселона"},
                new Player {Name="Неймар", Team="Барселона"},
                new Player {Name="Роббен", Team="Бавария"}
            };

            var result = from pl in players
                         join t in teams
                         on pl.Team equals t.Name
                         select new { Name = pl.Name, Team = pl.Team, Country = t.Country };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Team} ({item.Country})");
            }

            Console.WriteLine(new string('-', 10));

            //То же самое действие можно было бы выполнить с помощью метода Join(
            var result1 = players.Join(teams, // второй набор
             p => p.Team, // свойство-селектор объекта из первого набора
             t => t.Name, // свойство-селектор объекта из второго набора
             (p, t) => new { Name = p.Name, Team = p.Team, Country = t.Country }); // результат


            foreach (var item in result1)
            {
                Console.WriteLine($"{item.Name} - {item.Team} ({item.Country})");
            }

            // Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс играков
    /// </summary>
    class Player
    {
        /// <summary>
        /// Имя игрока
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Команда
        /// </summary>
        public string Team { get; set; }
    }

    /// <summary>
    /// Класс команд
    /// </summary>
    class Team
    {
        /// <summary>
        /// Имя команды
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string Country { get; set; }
    }
}
