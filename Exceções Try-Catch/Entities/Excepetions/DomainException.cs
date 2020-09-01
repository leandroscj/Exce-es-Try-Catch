using System;

namespace Exceções_Try_Catch.Entities.Excepetions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}