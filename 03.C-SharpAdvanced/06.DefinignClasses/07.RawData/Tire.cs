using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        public Tire(double tirePressure, int tireYear)
        {
            TirePressure = tirePressure;
            TireYear = tireYear;
        }

        public double TirePressure { get; set; }
        public int  TireYear { get; set; }
        
    }
}
