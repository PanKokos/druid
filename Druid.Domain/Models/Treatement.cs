using Druid.Domain.Models.Dosing;
using Druid.Domain.Models.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace Druid.Domain.Models
{
    public class Treatement
    {
        public Treatement(Medicine medicine, Dose dosing)
        {
            Medicine = medicine;
            Dosing = dosing;
        }

        public Medicine Medicine { get; }
        public Dose Dosing { get; }
    }
}
