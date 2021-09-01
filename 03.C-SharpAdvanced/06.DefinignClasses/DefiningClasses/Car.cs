using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double traveledDistance;
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumption;
            
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        

        public void Travel( double distance)
        {
            if (FuelAmount >= (FuelConsumptionPerKilometer * distance))
            {
                FuelAmount -= (FuelConsumptionPerKilometer * distance);
                traveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public void PrintCarOnConsole()
        {
            Console.WriteLine($"{Model} {FuelAmount:f2} {traveledDistance}");
        }
    }
}
