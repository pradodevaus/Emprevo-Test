using System;
using System.Collections.Generic;
using System.Text;

namespace CalcEngine
{
    interface IRate
    {
        string RateName { get;}

        //RateType RateType { get; }

        //decimal Price { get; }

        //TimeSpan EntryStart { get; }

        //TimeSpan EntryEnd { get;}

        //TimeSpan ExitStart { get;}

        //TimeSpan ExitEnd { get; }

        bool IsValid(DateTime entry, DateTime exit);

        decimal Calculate(DateTime entry, DateTime exit);
    }
}
