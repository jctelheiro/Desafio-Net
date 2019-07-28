using System;
using System.Runtime.Serialization;

namespace CheckingAccount.Domain.Exceptions
{
    public class CheckingAccountDomainException : Exception
    {
        public CheckingAccountDomainException()
        {
        }

        public CheckingAccountDomainException(string message) : base(message)
        {
        }

        public CheckingAccountDomainException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CheckingAccountDomainException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
