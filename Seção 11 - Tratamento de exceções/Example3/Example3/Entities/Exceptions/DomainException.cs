using System;
using System.Collections.Generic;
using System.Text;

namespace Example3.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        // Constructors
        public DomainException(string message) : base(message) { }
    }
}
