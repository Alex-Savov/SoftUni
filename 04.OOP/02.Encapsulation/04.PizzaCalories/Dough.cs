using System;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private const int maxDoughWeight = 200;
        private const int minDoughWeight = 1;
        private string type;
        private double weight;
        private string technique;

        public Dough(string type, string technique, double weight)
        {
            SetType(type);
            SetTechnique(technique);
            SetWeight(weight);
        }

        public double GetCalories()
        {
            double calories =  2 * this.weight * GetTypeModifier(this.type) * GetTechniqueModifier(this.technique);
            return calories;
        }

        private double GetTechniqueModifier(string technique)
        {
            string test = technique.ToLower();

            if (test == "crispy")
            {
                return 0.9;
            }
            else if (test == "chewy")
            {
                return 1.1;
            }
            return 1;
        }

        private double GetTypeModifier(string type)
        {
            if (type.ToLower() == "white")
            {
                return 1.5;
            }
            return 1;
        }

        private void SetType(string type)
        {
            string testValue = type.ToLower();

            if (testValue != "white"
                && testValue != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.type = type;
        }

        private void SetWeight(double weight)
        {
            if (weight < minDoughWeight || weight > maxDoughWeight)
            {
                throw new ArgumentException($"Dough weight should be in the range[{minDoughWeight}..{maxDoughWeight}].");
            }
            this.weight = weight;
        }


        private void SetTechnique(string technique)
        {
            string testTechnique = technique.ToLower();

            if (testTechnique != "crispy"
                && testTechnique != "chewy"
                && testTechnique != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.technique = technique;
        }
    }
}
