using System;

namespace StreetRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Sample Code Usage:

            //Initialize Race
            Race race = new Race("RockPort Race", "Sprint", 1, 2, 150);

            ////Initialize Car
            //Car car = new Car("BMW", "320ci", "NFS2005", 99, 1450);
            //Car car2 = new Car("Mercedes", "320ci", "NFS2005A", 120, 1450);
            //Car car3 = new Car("Audi", "320ci", "NFS2005B", 165, 1450);
            //Car car4 = new Car("Vw", "320ci", "NFS2005C", 100, 1450);
            //Car car5 = new Car("Toyota", "320ci", "NFS2005D", 200, 1450);

            //race.Add(car);
            //race.Add(car2);
            //race.Add(car3);
            //race.Add(car4);
            //race.Add(car5);

            Console.WriteLine(race.GetMostPowerfulCar());


            ;



            ////Print car
            //Console.WriteLine(car.ToString());

            ////Make: BMW
            ////Model: 320ci
            ////License Plate: NFS2005
            ////Horse Power: 150
            ////Weight: 1450

            ////Add car
            //race.Add(car);

            ////Remove car
            //Console.WriteLine(race.Remove("NFS2005")); // True

            //Car carOne = new Car("BMW", "320cd", "NFS2007", 150, 1350);
            //Car carTwo = new Car("Audi", "A3", "NFS2004", 131, 1300);

            ////Add cars
            //race.Add(carOne);
            //race.Add(carTwo);

            ////GetMostPowerfulCar
            //Console.WriteLine(race.GetMostPowerfulCar());

            ////Make: BMW
            ////Model: 320cd
            ////License Plate: NFS2007
            ////Horse Power: 150
            ////Weight: 1350


            ////Print Race report
            //Console.WriteLine(race.Report());

            ////Race: RockPort Race - Type: Sprint (Laps: 1)
            ////Make: BMW
            ////Model: 320cd
            ////License Plate: NFS2007
            ////Horse Power: 150
            ////Weight: 1350
            ////Make: Audi
            ////Model: A3
            ////License Plate: NFS2004
            ////Horse Power: 131
            ////Weight: 1300

            //Console.WriteLine(race.FindParticipant("54164"));
        }
    }
}
