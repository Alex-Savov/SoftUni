using System;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private const int minSkillRate = 0;
        private const int maxSkillRtae = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name 
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        public int Endurance 
        { 
            get => this.endurance;
            private set
            {
                RateValidator(value, "Endurance");
                this.endurance = value;
            }
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                RateValidator(value, "Sprint");
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                RateValidator(value, "Dribble");
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                RateValidator(value, "Passing");
                this.passing = value;
            }
        }
        public int Shooting 
        {
            get => this.shooting;
            private set
            {
                RateValidator(value, "Shooting");
                this.shooting = value;
            }
        }

        public double GetAverageRate()
        {
            double average = (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
            return average;
        }

        private void RateValidator(int rate, string stat)
        {
            if (rate < minSkillRate || rate > maxSkillRtae)
            {
                throw new ArgumentException($"{stat} should be between {minSkillRate} and {maxSkillRtae}.");
            }
        }
    }
}
