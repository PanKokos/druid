namespace Druid.Domain.Models.Units
{
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
}
