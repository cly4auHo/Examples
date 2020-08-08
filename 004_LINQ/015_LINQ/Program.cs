using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Метод GroupJoin кроме соединения последовательностей также выполняет и группировку. 
/// </summary>
namespace _015_LINQ
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

            var result = teams.GroupJoin(
                        players, // второй набор
                        t => t.Name, // свойство-селектор объекта из первого набора
                        pl => pl.Team, // свойство-селектор объекта из второго набора
                        (team, pls) => new  // результирующий объект
                        {
                            Name = team.Name,
                            Country = team.Country,
                            Players = pls.Select(p => p.Name)
                        });


            foreach (var team in result)
            {
                Console.WriteLine(new string('-', 10));
                Console.WriteLine(team.Name);

                foreach (string player in team.Players)
                {
                    Console.WriteLine(player);
                }

                Console.WriteLine(new string('-', 10));
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
