using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedforSpeed
{
    class Car
    {
        public string Make { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }

        public override string ToString()
        {
            return $"{Make} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < lines; i++)
            {
                string[] carData = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string make = carData[0];
                int mielage = int.Parse(carData[1]);
                int fuel = int.Parse(carData[2]);

                if (mielage < 100000)
                {
                    cars.Add(new Car { Make = make, Mileage = mielage, Fuel = fuel });
                }
            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "Stop")
            {
                string[] tokens = inputCommand
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string car = tokens[1];
                int index = cars.FindIndex(c => c.Make == car);

                switch (command)
                {
                    case "Drive":
                        int distance = int.Parse(tokens[2]);
                        int fuel = int.Parse(tokens[3]);

                        if (cars[index].Fuel >= fuel)
                        {
                            cars[index].Mileage += distance;
                            cars[index].Fuel -= fuel;

                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                            if (cars[index].Mileage >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car}!");
                                cars.RemoveAt(index);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }

                        break;

                    case "Refuel":
                        int refilFuel = int.Parse(tokens[2]);

                        if ((cars[index].Fuel + refilFuel) > 75)
                        {
                            Console.WriteLine($"{car} refueled with {75 - cars[index].Fuel} liters");
                            cars[index].Fuel = 75;
                        }
                        else
                        {
                            Console.WriteLine($"{car} refueled with {refilFuel} liters");
                            cars[index].Fuel += refilFuel;
                        }

                        break;

                    case "Revert":
                        int kilometers = int.Parse(tokens[2]);

                        if ((cars[index].Mileage- kilometers) <= 10000)
                        {
                            cars[index].Mileage = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                            cars[index].Mileage -= kilometers;
                        }
                        break;
                }

                inputCommand = Console.ReadLine();
            }

            cars = cars
                .OrderByDescending(c => c.Mileage)
                .ThenBy(c => c.Make)
                .ToList();

            Console.WriteLine(string.Join("\n", cars.Select(c => c.ToString())));
        }
    }
}
