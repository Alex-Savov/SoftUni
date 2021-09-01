using System;
using System.Linq;

namespace _08.SalesMan
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Engine[] engines = new Engine[n];

            for (int i = 0; i < n; i++)
            {
                string[] engineData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = engineData[0];
                int power = int.Parse(engineData[1]);

                if (engineData.Length == 4)
                {
                    int displacement = int.Parse(engineData[2]);
                    string efficiecy = engineData[3];
                    engines[i] = new Engine(model, power, displacement, efficiecy);
                }
                else if (engineData.Length == 3)
                {
                    int displacement = 0;

                    if (int.TryParse(engineData[2], out displacement))
                    {
                        displacement = int.Parse(engineData[2]);
                        engines[i] = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engines[i] = new Engine(model, power) {Efficiency = engineData[2] };
                    }
                }
                else
                {
                    engines[i] = new Engine(model, power);
                }
            }

            int maxCars = int.Parse(Console.ReadLine());
            Car[] cars = new Car[maxCars];

            for (int i = 0; i < maxCars; i++)
            {
                string[] carData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carData[0];
                Engine engine = engines.FirstOrDefault(c => c.Model == carData[1]);

                if (carData.Length == 4)
                {
                    int weight = int.Parse(carData[2]);
                    string color = carData[3];
                    cars[i] = new Car(model, engine, weight, color);
                }
                else if (carData.Length == 3)
                {
                    int weight = 0;
                    if (int.TryParse(carData[2], out weight))
                    {
                        weight = int.Parse(carData[2]);
                        cars[i] = new Car(model, engine, weight);
                    }
                    else
                    {
                        cars[i] = new Car(model, engine) { Color = carData[2] };
                    }
                }
                else
                {
                    cars[i] = new Car(model, engine);
                }
            }

            foreach (var car in cars)
            {
                car.PrintCar();
            }
        }
    }
}
