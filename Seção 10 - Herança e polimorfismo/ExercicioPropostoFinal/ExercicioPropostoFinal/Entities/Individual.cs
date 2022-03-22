using ExercicioPropostoFinal.Entities;
using System.Globalization;

namespace ExercicioPropostoFinal.Entities
{
    internal class Individual : TaxPayer
    {
        // AutoProps
        public double HealthExpenditures { get; set; }

        // Constructors
        public Individual(string name, double anualIncome, double healthExpends) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpends;
        }

        // Methods
        public override double Taxes()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }

        public override string ShowTaxes()
        {
            return $"{Name}: ${Taxes().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
