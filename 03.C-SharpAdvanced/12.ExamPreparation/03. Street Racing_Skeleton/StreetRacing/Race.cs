using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        private readonly List<Car> participants;

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            participants = new List<Car>();
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
        }

      
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public int Count
        {
            get
            {
                return participants.Count;
            }
        }
       

        public void Add(Car car)
        {
            if ((!this.participants.Any(c => c.LicensePlate == car.LicensePlate))
                && (Capacity > participants.Count)
                && (car.HorsePower <= MaxHorsePower))
            {
                participants.Add(car);
            }
        }

        public bool Remove(string licensePlate)
        {
            if (FindParticipant(licensePlate) != null)
            {
                participants.Remove(FindParticipant(licensePlate));
                return true;
            }

            return false;
        }

        public Car FindParticipant(string licensePlate)
        {
            return participants.FirstOrDefault(c => c.LicensePlate == licensePlate); ;
        }

        public Car GetMostPowerfulCar()
        {
            if (Count == 0)
            {
                return default(Car);
            }

            return participants.OrderByDescending(p => p.HorsePower).First();
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");

            foreach (var car in participants)
            {
                output.AppendLine(car.ToString());
            }

            return output.ToString();
        }
    }
}
