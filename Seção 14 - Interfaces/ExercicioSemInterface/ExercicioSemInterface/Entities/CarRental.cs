using System;
using System.Globalization;

namespace ExercicioSemInterface.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null; // Adicionado manualmente. Mas o sistema faz automaticamente tambem
        }
    }
}
