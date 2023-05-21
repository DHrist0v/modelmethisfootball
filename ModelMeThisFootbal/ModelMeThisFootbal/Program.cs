using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThisFootbal
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class FootballPlayer : Person
        {
            public int Number { get; set; }
            public double Height { get; set; }
        }

        public class Goalkeeper : FootballPlayer { }
        public class Defender : FootballPlayer { }
        public class Midfielder : FootballPlayer { }
        public class Striker : FootballPlayer { }
        public class Coach : Person { }
        public class Referee : Person { }

        public class Team
        {
            public Coach Coach { get; set; }
            public List<FootballPlayer> PlayersT { get; set; }

            public double AverageAge()
            {
                double allage = 0;
                foreach (FootballPlayer x in PlayersT)
                {
                    allage = allage + x.Age;
                }

                return (allage / PlayersT.Count);
            }
        }
        public class Game
        {
            public Team Team1 { get; set; }
            public Team Team2 { get; set; }
            public Referee Referee { get; set; }

            public string Winner { get; set; }
            public string Result { get; set; }
            public List<Goal> Goals { get; set; }

            public class Goal
            {
                public string TeamGoalName { get; set; }
                public int Minute { get; set; }
                public FootballPlayer Player { get; set; }
            }

            public void Print()
            {
                Console.WriteLine("Rezultat: " + Result);
                Console.WriteLine("Pecheli: " + Winner);

                Console.WriteLine("Golove:");
                foreach (Goal goal in Goals)
                {
                    Console.WriteLine("Team: " + goal.TeamGoalName + ", Minute: " + goal.Minute + ", Player: " + goal.Player.Name);
                }
            }
        }

        static void Main(string[] args)
        {
            List<FootballPlayer> playersteam1 = new List<FootballPlayer>();
            playersteam1.Add(new Striker { Name = "Cristiano Ronaldo", Number = 9, Age = 20, Height = 1.85 });
            playersteam1.Add(new Striker { Name = "Lionel Messi", Number = 10, Age = 27, Height = 1.82 });
            playersteam1.Add(new Midfielder { Name = "Neymar Jr.", Number = 7, Age = 21, Height = 1.75 });
            playersteam1.Add(new Midfielder { Name = "Kylian Mbappé", Number = 11, Age = 33, Height = 1.80 });
            playersteam1.Add(new Defender { Name = "Robert Lewandowski", Number = 2, Age = 19, Height = 1.83 });
            playersteam1.Add(new Defender { Name = "Mohamed Salah", Number = 4, Age = 21, Height = 1.79 });
            playersteam1.Add(new Defender { Name = "Kevin De Bruyne", Number = 5, Age = 24, Height = 1.81 });
            playersteam1.Add(new Goalkeeper { Name = "Sergio Ramos", Number = 1, Age = 26, Height = 1.88 });
            playersteam1.Add(new Midfielder { Name = "Virgil van Dijk", Number = 8, Age = 27, Height = 1.77 });
            playersteam1.Add(new Midfielder { Name = "Harry Kane", Number = 6, Age = 29, Height = 1.76 });
            playersteam1.Add(new Striker { Name = "Manuel Neuer", Number = 20, Age = 21, Height = 1.84 });


            List<FootballPlayer> playersteam2 = new List<FootballPlayer>();
            playersteam2.Add(new Striker { Name = "Eden Hazard", Number = 9, Age = 25, Height = 1.85 });
            playersteam2.Add(new Striker { Name = "Antoine Griezmann", Number = 10, Age = 27, Height = 1.82 });
            playersteam2.Add(new Midfielder { Name = "Luka Modrić", Number = 7, Age = 24, Height = 1.75 });
            playersteam2.Add(new Midfielder { Name = "Paulo Dybala", Number = 11, Age = 26, Height = 1.80 });
            playersteam2.Add(new Defender { Name = "Sadio Mané", Number = 2, Age = 28, Height = 1.83 });
            playersteam2.Add(new Defender { Name = "Raheem Sterling", Number = 4, Age = 23, Height = 1.79 });
            playersteam2.Add(new Defender { Name = "Pierre-Emerick Aubameyang", Number = 5, Age = 25, Height = 1.81 });
            playersteam2.Add(new Goalkeeper { Name = "Alisson Becker", Number = 1, Age = 29, Height = 1.88 });
            playersteam2.Add(new Midfielder { Name = "Toni Kroos", Number = 8, Age = 26, Height = 1.77 });
            playersteam2.Add(new Midfielder { Name = "Thiago Silva", Number = 6, Age = 24, Height = 1.76 });
            playersteam2.Add(new Striker { Name = "N'Golo Kanté", Number = 20, Age = 28, Height = 1.84 });


            Coach coach1 = new Coach { Name = "Iwan", Age = 40 };
            Coach coach2 = new Coach { Name = "Petur", Age = 50 };

            Referee referee = new Referee { Name = "Georgi Dimitrow", Age = 25 };

            Team team1 = new Team { Coach = coach1, PlayersT = playersteam1 };
            Team team2 = new Team { Coach = coach2, PlayersT = playersteam2 };
            Console.WriteLine($"Average team1 age: {Math.Round(team1.AverageAge())}");
            Console.WriteLine($"Average team2 age: {Math.Round(team2.AverageAge())}");
            Console.WriteLine("");


            List<Game.Goal> goals = new List<Game.Goal>();
            goals.Add(new Game.Goal { TeamGoalName = "team1", Minute = 5, Player = playersteam1[1] });
            goals.Add(new Game.Goal { TeamGoalName = "team1", Minute = 7, Player = playersteam1[2] });

            goals.Add(new Game.Goal { TeamGoalName = "team2", Minute = 10, Player = playersteam2[1] });
            goals.Add(new Game.Goal { TeamGoalName = "team2", Minute = 15, Player = playersteam2[5] });
            goals.Add(new Game.Goal { TeamGoalName = "team2", Minute = 16, Player = playersteam2[6] });
            goals.Add(new Game.Goal { TeamGoalName = "team2", Minute = 35, Player = playersteam2[8] });
            goals.Add(new Game.Goal { TeamGoalName = "team2", Minute = 48, Player = playersteam2[4] });
            goals.Add(new Game.Goal { TeamGoalName = "team2", Minute = 55, Player = playersteam2[9] });

            Game game1 = new Game { Team1 = team1, Team2 = team2, Referee = referee, Goals = goals, Result = "2:6", Winner = "team2" };
            game1.Print();
        }
    }
}

