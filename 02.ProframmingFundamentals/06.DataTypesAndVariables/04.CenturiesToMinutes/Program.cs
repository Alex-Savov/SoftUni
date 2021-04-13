using System;
using System.Numerics;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort centurie = ushort.Parse(Console.ReadLine());
            ushort years =(ushort)( centurie * 100);
            int days = (int) (years * 365.2422);
            long hours = days * 24;
            BigInteger minutes = new BigInteger(hours * 60);
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes"
                , centurie, years, days, hours, minutes);
        }
    }
}
