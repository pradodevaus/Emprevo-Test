using System;

namespace CalcEngine
{
    public class WeekendRate : IRate
    {
        public string RateName { get => "Weekend Rate"; }

        //private readonly RateType RateType = RateType.Flat;
        //private readonly DayOfferType DayOfferType = DayOfferType.All;
        private readonly decimal Price = 10.00m;

        private readonly TimeSpan EntryStart = TimeSpan.FromMinutes(1);
        private readonly TimeSpan EntryEnd = TimeSpan.FromMinutes(1439);
        private readonly TimeSpan ExitStart = TimeSpan.FromMinutes(1);
        private readonly TimeSpan ExitEnd = TimeSpan.FromMinutes(1439);

        public decimal Calculate(DateTime entry, DateTime exit)
        {
            return Price;
        }

        public bool IsValid(DateTime entry, DateTime exit)
        {
            if (entry >= exit) return false;

            if (!((entry.DayOfWeek == DayOfWeek.Saturday || entry.DayOfWeek == DayOfWeek.Sunday)
                && (exit.DayOfWeek == DayOfWeek.Saturday || exit.DayOfWeek == DayOfWeek.Sunday)))
                return false;

            if (!(entry.TimeOfDay >= EntryStart && entry.TimeOfDay <= EntryEnd
                && exit.TimeOfDay >= ExitStart && exit.TimeOfDay <= ExitEnd))
                return false;

            return true;
        }
    }
}