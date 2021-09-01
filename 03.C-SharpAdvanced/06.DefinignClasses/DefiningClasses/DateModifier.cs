using System;

namespace DefiningClasses
{
    public class DateModifier
    {
        public double DifferenceBetweenDates(string firstDate, string secondDate)
        {
            DateTime first = DateTime.Parse(firstDate);
            DateTime second = DateTime.Parse(secondDate);
            return Math.Abs((first - second).TotalDays);
        }
    }
}
