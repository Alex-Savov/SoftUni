using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        public Engine(int power, int speed)
        {
            Power = power;
            Speed = speed;
        }

        public int Power { get; set; }
        public int Speed { get; set; }
    }
}
