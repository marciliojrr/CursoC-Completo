using System.Globalization;

namespace ExercicioFixacaoLists
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            double raise = Salary * (percentage / 100.0);
            Salary += raise;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
