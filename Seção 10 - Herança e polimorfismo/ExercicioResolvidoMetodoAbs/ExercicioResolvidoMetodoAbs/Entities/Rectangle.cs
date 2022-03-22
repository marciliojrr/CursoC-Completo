using ExercicioResolvidoMetodoAbs.Entities.Enums;

namespace ExercicioResolvidoMetodoAbs.Entities

{
    internal class Rectangle : Shape
    {
        // AutoProps
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructors
        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        // Methods
        public override double Area()
        {
            return Width * Height;
        }
    }
}