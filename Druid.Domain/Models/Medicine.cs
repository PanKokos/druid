using Druid.Domain.Models.Units;

namespace Druid.Domain.Models
{
    public class Medicine
    {
        public Medicine(string name, Quantity size, Quantity strenght, string remarks, bool isPrescriptionRequired)
        {
            Name = name;
            Size = size;
            Strenght = strenght;
            Remarks = remarks;
            IsPrescriptionRequired = isPrescriptionRequired;
        }

        public string Name { get; }
        public Quantity Size { get; }  // the size of the package
        public Quantity Strenght { get; }
        public string Remarks { get; }
        public bool IsPrescriptionRequired { get; }
    }
}
