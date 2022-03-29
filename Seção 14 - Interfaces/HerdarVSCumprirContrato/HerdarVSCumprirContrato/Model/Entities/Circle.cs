using System;
using System.Globalization;
using HerdarVSCumprirContrato.Model.Entities;

namespace HerdarVSCumprirContrato.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Circle color = {Color}\nRadius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}\nArea = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
