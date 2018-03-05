using System;

namespace CalcEngine
{
    public class NightRate : IRate
    {
        public string RateName { get => "Night Rate"; }

        //private readonly RateType RateType = RateType.Flat;
        //private readonly DayOfferType DayOfferType = DayOfferType.All;
        private readonly decimal Price = 6.50m;

        private readonly TimeSpan EntryStart = TimeSpan.FromMinutes(1080);
        private readonly TimeSpan EntryEnd = TimeSpan.FromMinutes(1439);
        private readonly TimeSpan ExitStart = TimeSpan.FromMinutes(0);
        private readonly TimeSpan ExitEnd = TimeSpan.FromMinutes(359);

        public decimal Calculate(DateTime entry, DateTime exit)
        {
            return Price;
        }

        public bool IsValid(DateTime entry, DateTime exit)
        {
            if (entry >= exit) return false;

            if (entry.DayOfWeek == DayOfWeek.Saturday || entry.DayOfWeek == DayOfWeek.Sunday)
                return false;

            if (!(entry.TimeOfDay >= EntryStart && entry.TimeOfDay <= EntryEnd
                && exit.TimeOfDay >= ExitStart && exit.TimeOfDay <= ExitEnd))
                return false;

            return true;
        }
    }
}