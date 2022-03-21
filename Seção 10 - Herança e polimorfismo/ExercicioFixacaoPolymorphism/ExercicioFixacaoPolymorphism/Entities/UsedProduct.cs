using System;
using System.Globalization;

namespace ExercicioFixacaoPolymorphism.Entities
{
    internal class UsedProduct : Product
    {
        // AutoProps
        public DateTime ManufactureDate { get; protected set; }

        // Constructors
        public UsedProduct() { } // Empty constructor

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            ManufactureDate = date;
        }

        // Methods
        public override string PriceTag()
        {
            return $"{Name} (used) ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
