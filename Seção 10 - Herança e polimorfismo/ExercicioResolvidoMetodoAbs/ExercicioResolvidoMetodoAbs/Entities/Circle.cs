using System;
using ExercicioResolvidoMetodoAbs.Entities.Enums;

namespace ExercicioResolvidoMetodoAbs.Entities
{
    internal class Circle : Shape
    {
        // AutoProps
        public double Radius { get; set; }

        // Constructors
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        // Methods
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
