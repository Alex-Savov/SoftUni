using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            double percentP1 = 1.0 * p1 / n * 100;
            double percentP2 = 1.0 * p2 / n * 100;
            double percentP3 = 1.0 * p3 / n * 100;
            double percentP4 = 1.0 * p4 / n * 100;
            double percentP5 = 1.0 * p5 / n * 100;

            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%\n{3:f2}%\n{4:f2}%",
               percentP1, percentP2, percentP3, percentP4, percentP5 );
        }
    }
}
