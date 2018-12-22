using System.Collections.Generic;

namespace Druid.Domain.Models
{
    public class Prescription
    {
        private readonly List<Treatement> _treatements;
        private readonly List<Recomendation> _recomendations;

        public Prescription()
        {
            _treatements = new List<Treatement>();
            _recomendations = new List<Recomendation>();
        }

        public void AddTreatement(Treatement treatement)
        {
            _treatements.Add(treatement);
        }

        public void AddRecomendation(Recomendation recomendation)
        {
            _recomendations.Add(recomendation);
        }
    }
}
