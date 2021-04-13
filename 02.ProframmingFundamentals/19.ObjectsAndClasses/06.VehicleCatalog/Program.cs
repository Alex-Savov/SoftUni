using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _06.VehicleCatalog
{
    // create class Car
    class Car
    {
        // prop Type
        public string Type
        {
            get
            {
                return "Car";
            }
        }
        // prop Model
        public string Model { get; set; }
        // prop Color
        public string Color { get; set; }
        // prop HorsePower
        public int HorsePower { get; set; }
        // override toString
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Type: {Type}");
            output.AppendLine($"Model: {Model}");
            output.AppendLine($"Color: {Color}");
            output.Append($"Horsepower: {HorsePower}");
            return output.ToString().TrimEnd();
        }
    }

    // create class Truck
    class Truck
    {
        // prop Type
        public string Type 
        {
            get
            {
                return "Truck";
            }
        }
        // prop Model
        public string Model { get; set; }
        // prop Color
        public string Color { get; set; }
        // prop HorsePower
        public int HorsePower { get; set; }
        // override toString
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Type: {Type}");
            output.AppendLine($"Model: {Model}");
            output.AppendLine($"Color: {Color}");
            output.Append($"Horsepower: {HorsePower}");
            return output.ToString().TrimEnd();
        }
    }

    // create class Catalogue
    class Catalogue
    {
        //prop list of Car
        public List<Car> Cars { get; set; }

        //prop list of Trck
        public List<Truck> Trucks { get; set; }

        //generate ctor with new lists for the properties
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public double AverageHoespowerCars()
        {
            if (Cars.Count == 0)
            {
                return 0.0;
            }
            return (double)(Cars.Sum(x => x.HorsePower)) / Cars.Count;
        }

        public double AverageHorsePowerTrucks()
        {
            if (Trucks.Count == 0)
            {
                return 0.0;
            }
            return (double)(Trucks.Sum(x => x.HorsePower)) / Trucks.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // initiate new catalogue object
            Catalogue catalogue = new Catalogue();

            // initiate while loop until input == "End"
            while(true)
            {
                // get the input string
                string inputData = Console.ReadLine();

                if (inputData == "End")
                {
                    break;
                }
                //get vehicle data by splitting the input by whitespace
                string[] vehicleData = inputData
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = vehicleData[0];
                string model = vehicleData[1];
                string color = vehicleData[2];
                int horsePower = int.Parse(vehicleData[3]);

                //if vehicle type is car
                if (type == "car")
                {
                    //initiate new car object and add it to catalaogue.cars

                    catalogue.Cars.Add(new Car
                    {
                        Model = model,
                        Color = color,
                        HorsePower = horsePower
                    });
                }
                else if (type == "truck") //if vehicle is truck
                {
                    //initiate new truck object and add it to catalaogue.trucks

                    catalogue.Trucks.Add(new Truck
                    {
                        Model = model,
                        Color = color,
                        HorsePower = horsePower
                    });
                }
            }

            //get input for search
            string searchModel = Console.ReadLine();

            //generate while loop until input == "Close the Catalogue"
            while (searchModel != "Close the Catalogue")
            {
                //print the item according to the search demand
                if (catalogue.Cars.Any(x => x.Model == searchModel))
                {
                    Console.WriteLine(catalogue.Cars.First(x => x.Model == searchModel)
                        .ToString());
                }
                else
                {
                    Console.WriteLine(catalogue.Trucks.First(x => x.Model == searchModel)
                        .ToString());
                }
               
                searchModel = Console.ReadLine();
            }

            //print the average horspower for the class car
            Console.WriteLine($"Cars have average horsepower of: {catalogue.AverageHoespowerCars():f2}.");

            //print the average horspower for the class truck
            Console.WriteLine($"Trucks have average horsepower of: {catalogue.AverageHorsePowerTrucks():f2}.");
        }
    }
}
