using Druid.Domain.Models.Units;

namespace Druid.Domain.Models.Dosing
{
    public class Dose
    {
        public Quantity Size { get; }
        public Frequency Frequency { get; }
        public Duration Lenght { get; }
    }
}
