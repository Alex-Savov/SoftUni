using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Car
    {
        //Brand, Model and Horse Power.
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            return $"{Brand}: {Model} - {HorsePower}hp";
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public override string ToString()
        {
            return $"{Brand}: {Model} - {Weight}kg";
        }
    }
    class Catalogue
    {
       public Catalogue()
        {
            CollectionCars = new List<Car>();
            CollectionTrucks = new List<Truck>();
        }

        public List<Car> CollectionCars { get; set; }
        public List<Truck> CollectionTrucks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Catalogue catalogue = new Catalogue();
            while (input != "end")
            {
                string[] vehicleData = input
                    .Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = vehicleData[0];
                string brand = vehicleData[1];
                string model = vehicleData[2];
                int WeightOrHP = int.Parse(vehicleData[3]);

                if (type == "Car")
                {
                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = WeightOrHP
                    };

                    catalogue.CollectionCars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = WeightOrHP
                    };

                    catalogue.CollectionTrucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            if (catalogue.CollectionCars.Count > 0)
            {
                Console.WriteLine($"Cars: \n{string.Join(Environment.NewLine, catalogue.CollectionCars.OrderBy(x => x.Brand))}");
            }

            if (catalogue.CollectionTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks: \n{string.Join(Environment.NewLine, catalogue.CollectionTrucks.OrderBy(x => x.Brand))}");
            }
        }
    }
}
