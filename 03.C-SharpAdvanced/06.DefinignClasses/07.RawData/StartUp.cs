using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                string model = data[0];
                int engineSpeed = int.Parse(data[1]);
                int enginePower = int.Parse(data[2]);
                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];

                Engine engine = new Engine(enginePower, engineSpeed);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tire[] tires = new Tire[4];
                int counter = 0;

                for (int j = 5; j < data.Length - 1; j++)
                {
                    double pressure = double.Parse(data[j]);
                    int year = int.Parse(data[j + 1]);
                    tires[counter] = new Tire(pressure, year);
                    counter++;
                    j++;
                }

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();

            if (command.ToLower() == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.CargoType == command))
                {
                    if (car.Tires.Any(t => t.TirePressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command.ToLower() == "flamable")
            {
                foreach (var car in cars.Where(c => c.Cargo.CargoType == command))
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
