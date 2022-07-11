using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var teams = new Dictionary<string,Team>();
            
            
            while (input != "END")
            {
                string[] data = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];
                try
                {
                    if (command == "Team")
                    {
                        string teamName = data[1];
                        
                        var team = new Team(teamName);
                        teams.Add(teamName, team);
                        
                    }
                    if (command == "Add")
                    {
                        var teamName = data[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }
                        string playerName = data[2];
                        int endurance = int.Parse(data[3]);
                        int sprint = int.Parse(data[4]);
                        int dribble = int.Parse(data[5]);
                        int passing = int.Parse(data[6]);
                        int shooting = int.Parse(data[7]);

                        var team = teams[teamName];

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        team.AddPlayer(player);
                    }
                    if (command == "Remove")
                    {
                        var teamName = data[1];
                        var playername = data[2];

                        var team = teams[teamName];
                        team.RemovePlayer(playername);
                    }
                    if (command == "Rating")
                    {
                        var teamName = data[1];
                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist."); continue;
                        }
                        var team = teams[teamName];
                        Console.WriteLine($"{teamName} - {team.Rating}");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                

                input = Console.ReadLine();
            }
        }
    }
}
