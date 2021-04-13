using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {

        public Box()
        {
            Item = new Item();
        }

        public double BoxPrice
        {
            get
            {
                return ItemQuantitny * Item.Price;
            }
        }

        public int SerialNumber { get; set; }
        public int ItemQuantitny { get; set; }
        public Item Item { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{SerialNumber}");
            output.AppendLine($"-- {Item.Name} - ${Item.Price:f2}: {ItemQuantitny}");
            output.Append($"-- ${BoxPrice:f2}");
            return output.ToString();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] boxData = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int serialNumber = int.Parse(boxData[0]);
                string itemName = boxData[1];
                int quantity = int.Parse(boxData[2]);
                double itemPrice = double.Parse(boxData[3]);


                Box box = new Box();
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.ItemQuantitny = quantity;
                box.SerialNumber = serialNumber;


                boxes.Add(box);
                input = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(x => x.BoxPrice).ToList();

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
