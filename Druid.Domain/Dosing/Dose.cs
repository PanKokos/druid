using System;
using System.Collections.Generic;
using System.Text;

namespace Druid.Domain.Dosing
{
    public class Dose
    {
    }

    public struct Quantity
    {
        public double Value { get; }
        public Quantities Unit { get; }

        public Quantity(double value, Quantities unit)
        {
            Value = value;
            Unit = unit;
        }
    }

    public class Frequency
    {
        public double Value { get; }
        public Frequencies Unit { get; }


    }

    public class Duration
    {
        public DateTime StartDate { get; }
        public TimeSpan Value { get; }
    }
}
