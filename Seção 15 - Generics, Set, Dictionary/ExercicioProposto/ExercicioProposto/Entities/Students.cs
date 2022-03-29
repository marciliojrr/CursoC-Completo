using System;

namespace ExercicioProposto.Entities
{
    internal class Students
    {
        public int RegistrationNumber { get; set; }

        public override int GetHashCode()
        {
            return RegistrationNumber.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Students))
            {
                return false;
            }
            Students other = (Students)obj;

            return RegistrationNumber.Equals(other.RegistrationNumber);
        }
    }
}
