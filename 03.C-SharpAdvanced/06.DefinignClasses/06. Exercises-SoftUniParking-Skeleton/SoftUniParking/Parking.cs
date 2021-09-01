using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        
        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;

        }

        public int Count 
        {
            get 
            {
                return cars.Count;
            }
        }

        public string AddCar(Car car)
        {
            string message = $"Successfully added new car {car.Make} {car.RegistrationNumber}";

            if (cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                message =  "Car with that registration number, already exists!";
            }
            else if (cars.Count == capacity)
            {
                message =  "Parking is full!";
            }
            else
            {
                cars.Add(car);
            }

            return message;
        }
        public string RemoveCar(string registrationNumber)
        {
            string message = $"Successfully removed {registrationNumber}";

            if (!cars.Any(cars => cars.RegistrationNumber == registrationNumber))
            {
                message = "Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.RemoveAll(c => c.RegistrationNumber == registrationNumber);
            }

            return message;
        }
        public Car GetCar(string registrationNumber)
        {
            return cars.FirstOrDefault(cars => cars.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var number in RegistrationNumbers)
            {
                if (cars.Any(c => c.RegistrationNumber == number))
                {
                    cars.RemoveAll(c => c.RegistrationNumber == number);
                }
            }
        }
    }
}
