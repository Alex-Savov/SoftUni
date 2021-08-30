using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tiresCollection = new List<Tire[]>();

            string tiresInput = Console.ReadLine();

            while (tiresInput.ToLower() != "no more tires")
            {
                string[] tireTokens = tiresInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Tire[] tires = new Tire[4];
                int counter = 0;

                for (int i = 0; i < tireTokens.Length; i+=2)
                {
                    int year = 0;
                    double pressure = 0;

                    if (int.TryParse(tireTokens[i], out year) && double.TryParse(tireTokens[i +1 ], out pressure))
                    {
                        tires[counter] = new Tire(year, pressure);
                        counter++;
                    }
                }

                tiresCollection.Add(tires);
                tiresInput = Console.ReadLine();
            }


            string enginesInput = Console.ReadLine();
            List<Engine> engines = new List<Engine>();

            while (enginesInput.ToLower() != "engines done")
            {
                string[] engineTokens = enginesInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int horsePower = 0;
                double cubicCapacity = 0;

                if (int.TryParse(engineTokens[0], out horsePower)
                    && double.TryParse(engineTokens[1], out cubicCapacity))
                {
                    engines.Add(new Engine(horsePower, cubicCapacity));
                }

                enginesInput = Console.ReadLine();
            }

            List<Car> allCars = new List<Car>();
            List<Car> specialCars = new List<Car>();
            string carDataInput = Console.ReadLine();

            while (carDataInput.ToLower() != "show special")
            {
                string[] carDataTokens = carDataInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string make = carDataTokens[0];
                string model = carDataTokens[1];
                int year = int.Parse(carDataTokens[2]);
                double fuelQuantity = double.Parse(carDataTokens[3]);
                double fuelconsumption = double.Parse(carDataTokens[4]);
                Tire[] tires = tiresCollection[int.Parse(carDataTokens[5])];
                Engine engine = engines[int.Parse(carDataTokens[6])];
                bool isNewer = year >= 2017;
                bool isPowerGreater = engine.HorsePower > 330;
                bool isPressureInRange = (tires.Sum(t => t.Pressure) >= 9)
                    && (tires.Sum(t => t.Pressure) <= 10);

                if (isNewer && isPowerGreater && isPressureInRange)
                {
                    fuelQuantity -= fuelconsumption * 0.2;
                    specialCars.Add(new Car(make, model, year, fuelQuantity, fuelconsumption, engine, tires));
                }

                allCars.Add(new Car(make, model, year, fuelQuantity, fuelconsumption, engine, tires));
                carDataInput = Console.ReadLine();
            }

            foreach (var specialCar in specialCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}
