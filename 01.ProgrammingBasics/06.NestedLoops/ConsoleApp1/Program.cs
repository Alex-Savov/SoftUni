using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int student = 0;
            int standard = 0;
            int kid = 0;

            while (movieName != "Finish")
            {
                int seatsAvailabe = int.Parse(Console.ReadLine());
                int seatsBussy = 0;
                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    
                    if (ticketType == "student")
                    {
                        student++;
                    }
                    else if (ticketType == "standard")
                    {
                        standard++;
                    }
                    else if(ticketType == "kid")
                    {
                        kid++;
                    }

                    seatsBussy++;

                    if (seatsAvailabe == seatsBussy)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();

                }

                double percentFull = 1.0 * seatsBussy / seatsAvailabe * 100;
                Console.WriteLine($"{movieName} - {percentFull:f2}% full.");
                movieName = Console.ReadLine();
            }

            int allTickets = student + standard + kid;
            double sdudentPercent = 1.0 * student / allTickets * 100;
            double standardPercent = 1.0 * standard / allTickets * 100;
            double kidPercent = 1.0 * kid / allTickets * 100;

            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{sdudentPercent:f2}% student tickets.");
            Console.WriteLine($"{standardPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidPercent:f2}% kids tickets.");
        }
    }
}
