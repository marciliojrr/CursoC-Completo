using ExercicioResolvidoMetodoAbs.Entities.Enums;

namespace ExercicioResolvidoMetodoAbs.Entities
{
    internal abstract class Shape
    {
        // AutoProps
        public Color Color { get; set; }

        // Constructors
        // public Shape() { } // Construtor padrao nao criado para poder forcar a criacao de um objeto passando uma cor
        public Shape(Color color)
        {
            Color = color;
        }

        // Methods
        public abstract double Area(); // Ao declarar um metodo abstrato, temos que definir a classe como abstrata tambem
    }
}
