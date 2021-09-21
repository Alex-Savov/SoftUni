using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DefaultFuelConsumprion = 3;
        public Car(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelConsumprion;
        public override void Drive(double distance)
        {
            this.Fuel -= distance * this.FuelConsumption;
        }
    }
}
