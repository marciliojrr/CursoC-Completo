using System;

namespace Exercise.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        // Constructor
        public DomainException(string message) : base(message) { }
    }
}
