using System;

namespace Druid.Domain.Models.Dosing
{
    public struct Duration
    {
        public DateTime StartDate { get; }
        public DateTime EndDate => StartDate + Value;
        public TimeSpan Value { get; }

        public Duration(in DateTime startDate, TimeSpan durationValue)
        {
            StartDate = startDate;
            Value = durationValue;
        }
    }
}