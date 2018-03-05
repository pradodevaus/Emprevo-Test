using System;

namespace CalcEngine
{
    internal class HourlyRate : IRate
    {
        public string RateName => "Hourly Rate";

        public decimal Calculate(DateTime entry, DateTime exit)
        {
            var price = 0.0m;

            var dateDiff = exit - entry;

            var diff = (dateDiff.Days * 24) + dateDiff.Hours;

            if (diff >= 0 && diff <= 1)
                price = 5.0m;
            else if (diff >= 1 && diff <= 2)
                price = 10.0m;
            else if (diff >= 2 && diff <= 3)
                price = 15.0m;
            else
            {
                var totalDays = Math.Ceiling(((double)diff / 24));

                price = (int)totalDays * 20m;
            }

            return price;
        }

        public bool IsValid(DateTime entry, DateTime exit)
        {
            if (entry >= exit)
                return false;

            return true;
        }
    }
}