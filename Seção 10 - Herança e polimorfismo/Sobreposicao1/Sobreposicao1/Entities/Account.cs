namespace Sobreposicao1.Entities
{
    internal class Account
    {
        // AutoProps
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Ballance { get; protected set; }

        // Constructors
        public Account() { }

        public Account(int number, string holder, double ballance)
        {
            Number = number;
            Holder = holder;
            Ballance = ballance;
        }

        // Methods
        public virtual void WithDraw(double amount) // "virtual" permite que o metodo possa ser sobrescrito
        {
            Ballance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Ballance += amount;
        }
    }
}
