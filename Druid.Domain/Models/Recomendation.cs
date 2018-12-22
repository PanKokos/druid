using Druid.Domain.Models.Dosing;

namespace Druid.Domain.Models
{
    public class Recomendation
    {
        public Recomendation(string description, Dose dosing)
        {
            Description = description;
            Dosing = dosing;
        }

        public string Description { get; }
        public Dose Dosing { get; }
    }
}