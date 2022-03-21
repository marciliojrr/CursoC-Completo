using System.Globalization;

namespace ExercicioFixacaoPolymorphism.Entities
{
    internal class Product
    {
        // AutoProps
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        // Constructors
        public Product() { } // Empty constructor

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Methods
        public virtual string PriceTag()
        {
            return $"{Name} ${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
