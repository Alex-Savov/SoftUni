using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private const int maxTopping = 10;
        private const int minNameLenght = 1;
        private const int maxNameLenght = 15;
       

        private readonly List<Toppring> toppings;
        private string name;
       
        public Pizza(string name)
        {
            SetName(name);
            toppings = new List<Toppring>();
        }

        public Dough Dough { get; set; }

        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)
                || name.Length < minNameLenght
                || name.Length > maxNameLenght)
            {
                throw new ArgumentException($"Pizza name should be between {minNameLenght} and {maxNameLenght} symbols.");
            }

            this.name = name;
        }

        public int GetNumberOfToppings()
        {
            return this.toppings.Count;
        }

        public double GetTotalCalories()
        {
            double calories = this.Dough.GetCalories() + this.toppings.Sum(t => t.GetCalories());
            return calories;
        }

        public void AddTopping(Toppring topping)
        {
            if (GetNumberOfToppings() == maxTopping)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{maxTopping}].");
            }

            this.toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{this.name} - {this.GetTotalCalories():f2} Calories.";
        }
    }
}
