using System;
using System.Globalization;
using Exercise.Entities.Exceptions;

namespace Exercise.Entities
{
    internal class Account
    {
        // AutoProps
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        // Constructors
        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        // Methods
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("[Error] Insufficient funds.");
            }

            if (amount > WithdrawLimit)
            {
                throw new DomainException("[Error] Withdrawal amount greater than the allowed limit.");
            }

            UpdateBalance(amount);
            Console.WriteLine($"- New balance: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void UpdateBalance(double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"- Holder: {Holder}\n- Account number: {Number}\n- Balance: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}\n- Withdraw limit: ${WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
