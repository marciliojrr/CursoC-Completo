namespace ExercicioFixacaoComposicao.Entities
{
    internal class Product
    {
        // AutoProps
        public string Name { get; set; }
        public double Price { get; set; }

        // Constructors
        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
