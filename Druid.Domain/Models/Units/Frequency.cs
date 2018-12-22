namespace Druid.Domain.Models.Units
{
    public class Frequency
    {
        public double Value { get; }
        public Frequencies Unit { get; }

        public Frequency(double value, Frequencies frequency)
        {
            Value = value;
            Unit = frequency;
        }
    }
}
