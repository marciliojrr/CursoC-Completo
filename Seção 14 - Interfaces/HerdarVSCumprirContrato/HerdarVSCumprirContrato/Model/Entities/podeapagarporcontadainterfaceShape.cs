using HerdarVSCumprirContrato.Model.Enums;

namespace HerdarVSCumprirContrato.Model.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }
        
        public abstract double Area();
    }
}
