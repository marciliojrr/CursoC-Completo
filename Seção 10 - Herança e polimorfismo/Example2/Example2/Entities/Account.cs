namespace Example2.Entities
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
        public void WithDraw(double amount)
        {
            Ballance -= amount;
        }

        public void Deposit(double amount)
        {
            Ballance += amount;
        }
    }
}
