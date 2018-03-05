using System;
using System.Collections.Generic;

namespace CalcEngine
{
    public class ParkingEngine
    {
        private readonly List<IRate> Rates;

        public ParkingEngine()
        {
            Rates = new List<IRate>();
            Rates.Add(new EarlyBirdRate());
            Rates.Add(new NightRate());
            Rates.Add(new WeekendRate());
            Rates.Add(new HourlyRate());
        }

        public EngineResult GetTotal(DateTime entry, DateTime exit)
        {
            foreach (var rate in Rates)
            {
                if (rate.IsValid(entry, exit))
                {
                    var result = new EngineResult();
                    result.RateName = rate.RateName;
                    result.TotalPrice = rate.Calculate(entry, exit);

                    return result;
                }
            }

            return null;
        }
    }
}