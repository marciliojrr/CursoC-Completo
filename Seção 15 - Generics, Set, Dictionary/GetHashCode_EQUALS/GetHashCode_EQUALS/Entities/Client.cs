using System;
using System.Collections.Generic;
using System.Text;

namespace GetHashCode_EQUALS.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Client))
            {
                return false;
            }
            Client other = (Client)obj; // Downcasting
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
