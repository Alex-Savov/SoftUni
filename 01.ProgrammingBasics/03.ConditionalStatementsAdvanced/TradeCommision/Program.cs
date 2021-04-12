using System;

namespace TradeCommision
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commision = 0;
            
            if (city == "Sofia")
            {
                if (sales <= 500)
                {
                    commision = sales * 0.05;
                }
                else if (sales <= 1000)
                {
                    commision = sales * 0.07;
                }
                else if (sales <= 10000)
                {
                    commision = sales * 0.08;
                }
                else // sales > 10000
                {
                    commision = sales * 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (sales <= 500)
                {
                    commision = sales * 0.045;
                }
                else if (sales <= 1000)
                {
                    commision = sales * 0.075;
                }
                else if (sales <= 10000)
                {
                    commision = sales * 0.1;
                }
                else // sales > 10000
                {
                    commision = sales * 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales <= 500)
                {
                    commision = sales * 0.055;
                }
                else if (sales <= 1000)
                {
                    commision = sales * 0.08;
                }
                else if (sales <= 10000)
                {
                    commision = sales * 0.12;
                }
                else // sales > 10000
                {
                    commision = sales * 0.145;
                }
            }
            if (commision == 0 || sales < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{commision:f2}");
            }
        }
    }
}
