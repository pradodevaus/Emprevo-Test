using System;

namespace CalcEngine
{
    public class EarlyBirdRate : IRate
    {
        public string RateName { get => "Early Bird"; }
        //private readonly RateType RateType = RateType.Flat;
        //private readonly DayOfferType DayOfferType = DayOfferType.All;
        private readonly decimal Price = 13.00m;
        private readonly TimeSpan EntryStart = TimeSpan.FromMinutes(360);
        private readonly TimeSpan EntryEnd = TimeSpan.FromMinutes(540);
        private readonly TimeSpan ExitStart = TimeSpan.FromMinutes(930);
        private readonly TimeSpan ExitEnd = TimeSpan.FromMinutes(1410);

        public decimal Calculate(DateTime entry, DateTime exit)
        {
            return Price;
        }

        public bool IsValid(DateTime entry, DateTime exit)
        {
            if (entry >= exit)
                return false;

            if (!(entry.TimeOfDay >= EntryStart && entry.TimeOfDay <= EntryEnd
                && exit.TimeOfDay >= ExitStart && exit.TimeOfDay <= ExitEnd))
                return false;

            return true;
        }
    }
}
