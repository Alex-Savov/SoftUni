using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	The amount of money Ivan Cho has – floating - point number in range[0.00…1, 000.00]
            //•	The count of students – integer in range[0…100]
            //•	The price of lightsabers for a single sabre – floating - point number in range[0.00…100.00]
            //•	The price of robes for a single robe – floating - point number in range[0.00…100.00]
            //•	The price of belts for a single belt – floating - point number in range[0.00…100.00]

            double moneyAvailable = double.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double moneyForlightsabers = Math.Ceiling(studentsNumber * 1.1) * lightsaberPrice;
            double moneyForRobes = studentsNumber * robePrice;
            double moneyForBelts = beltPrice * (studentsNumber - Math.Floor(studentsNumber / 6.0));

            double moneyNeeded = moneyForlightsabers
                               + moneyForRobes 
                               + moneyForBelts;

           
            if (moneyAvailable < moneyNeeded)
            {
                double moneyDiff = Math.Abs(moneyAvailable - moneyNeeded);
                Console.WriteLine($"Ivan Cho will need {moneyDiff:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
        }
    }
}
