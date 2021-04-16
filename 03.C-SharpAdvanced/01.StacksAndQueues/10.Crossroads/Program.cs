using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
           
            Queue<string> q = new Queue<string>();
            int passedCars = 0;
            bool isThereCrash = false;

            while (true)
            {
                string input = Console.ReadLine();
                int currentGreenLight = greenLight;
                
                if (input.ToLower() == "end")
                {
                    break;
                }

                if (input.ToLower() == "green")
                {
                    int index = q.Count;

                    for (int i = 0; i < index; i++)
                    {
                        string car = q.Peek();

                        if (currentGreenLight == 0)
                        {
                            break;
                        }

                        if (currentGreenLight >= car.Length)
                        {
                            currentGreenLight -= car.Length;
                        }
                        else
                        {
                            string substring = car.Substring(0, currentGreenLight);
                            car = car.Replace(substring, "");

                            if (car.Length > freeWindow)
                            {
                                isThereCrash = true;
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{q.Peek()} was hit at {car[freeWindow]}.");
                                break;
                            }

                            currentGreenLight = 0;
                        }

                        q.Dequeue();
                        passedCars++;
                    }
                }
                else
                {
                    q.Enqueue(input);
                }

                if (isThereCrash)
                {
                    break;
                }
            }

            if (!isThereCrash)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
