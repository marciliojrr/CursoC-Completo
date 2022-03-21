namespace ExercicioResolvido.Entities
{
    internal class Employee
    {
        // AutoProps
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        // Constructors
        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        // Methods
        public virtual double Payment() // 'virtual' para que o metodo possa ser sobrescrito em 'OutsourcedEmployee'
        {
            return Hours * ValuePerHour;
        }
    }
}
