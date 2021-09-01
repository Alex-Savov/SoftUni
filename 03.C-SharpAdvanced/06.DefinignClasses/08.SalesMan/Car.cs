
using System.Text;

namespace _08.SalesMan
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = -1;
            Color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
            :this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, int weight, string color)
            :this(model, engine, weight)
        {
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public void PrintCar()
        {
            StringBuilder output = new StringBuilder();
            string displacement = Engine.Displacement == -1 ? "n/a" : Engine.Displacement.ToString();
            string weight = Weight == -1 ? "n/a" : Weight.ToString();

            output.AppendLine($"{Model}:");
            output.AppendLine($"  {Engine.Model}:");
            output.AppendLine($"     Power: {Engine.Power}");
            output.AppendLine($"     Displacement: {displacement}");
            output.AppendLine($"     Efficiency: {Engine.Efficiency}");
            output.AppendLine($"   Weight: {weight}");
            output.Append($"   Color: {Color}");

            System.Console.WriteLine(output.ToString());
        }
    }
}
