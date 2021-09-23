using System;

namespace _04.PizzaCalories
{
    public class Toppring
    {
        private const int maxWeight = 50;
        private const int minWeight = 1;
        private const int defaultCaloriesPerGram = 2;

        private string type;
        private double weight;

        public Toppring(string type, double weight)
        {
            SetType(type);
            SetWeight(weight);
        }

        public double GetCalories()
        {
            double calories = defaultCaloriesPerGram * SetTypeModifier(this.type) * this.weight;

            return calories;
        }

        private void SetWeight(double weight)
        {
            if (weight < minWeight || weight > maxWeight)
            {
                throw new ArgumentException($"{this.type} weight should be in the range [{minWeight}..{maxWeight}].");
            }

            this.weight = weight;
        }
        private void SetType(string type)
        {
            string testType = type.ToLower();

            if (testType != "meat"
                && testType != "veggies"
                && testType != "cheese"
                && testType != "sauce")
            {
                throw new ArgumentException($"Cannot place {type} on top of your pizza.");
            }

            this.type = type;
        }
        private double SetTypeModifier(string type)
        {
            string testType = type.ToLower();

            if (testType == "meat")
            {
               return 1.2;
            }
            else if (testType == "veggies")
            {
                return 0.8;
            }
            else if (testType == "cheese")
            {
               return 1.1;
            }

            return 0.9;
        }
    }
}
