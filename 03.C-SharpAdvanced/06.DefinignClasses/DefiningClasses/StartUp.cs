using System;
using System.Collections.Generic;

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
                string[] carData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumption = double.Parse(carData[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumption));
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[1];
                double distance = double.Parse(tokens[2]);

                cars.Find(car => car.Model == model).Travel(distance);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                car.PrintCarOnConsole();
            }
        }
    }
}
