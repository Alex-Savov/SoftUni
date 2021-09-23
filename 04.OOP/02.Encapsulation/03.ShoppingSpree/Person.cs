using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            bagOfProducts = new List<Product>();
            Name = name;
            Money = money;
        }

        public string Name 
        { 
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }


        public void AddProduct(Product product)
        {
            if (product.Cost > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            bagOfProducts.Add(product);
            this.Money -= product.Cost;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} - ");

            if (this.bagOfProducts.Count == 0)
            {
                sb.Append("Nothing bought");
                return sb.ToString();
            }

            sb.Append($"{string.Join(", ", this.bagOfProducts.Select(p => p.Name))}");
            return sb.ToString();
        }
    }
}
