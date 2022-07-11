using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int minStat = 0;
        private const int maxStat = 100;
              
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private int averageStat;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            
        }
        public string Name 
        { 
            get 
            { 
                return name; 
            } 
            private set
            {
                Validator.IsNameValid(value, $"A name should not be empty.");
                name = value;
            }
        }
        private int Endurance 
        {
            get
            {
                return this.endurance;
            }
            set
            {
                Validator.IsStatInRange(minStat, maxStat, value, "Endurance should be between 0 and 100.");
                this.endurance = value;
            }
        }
        private int Sprint 
        {
            get
            {
                return this.sprint;
            }
            set
            {
                Validator.IsStatInRange(minStat, maxStat, value, "Sprint should be between 0 and 100.");
                this.sprint = value;
            }
        }
        private int Dribble
        {
            get
            {
                return this.dribble;
            }
            set
            {
                Validator.IsStatInRange(minStat, maxStat, value, "Dribble should be between 0 and 100.");
                this.dribble = value;
            }
        }
        private int Passing 
        {
            get
            {
                return this.passing;
            }
            set
            {
                Validator.IsStatInRange(minStat, maxStat, value, $"Passing should be between 0 and 100.");
                this.passing = value;
            }
        }
        private int Shooting 
        {
            get
            {
                return this.shooting;
            }
            set
            {
                Validator.IsStatInRange(minStat, maxStat, value, $"Shooting should be between 0 and 100.");
                this.shooting = value;
            }
        }

        public double AverageStat() 
        {
           return Math.Round((this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0);
                        
        }

    }
}
