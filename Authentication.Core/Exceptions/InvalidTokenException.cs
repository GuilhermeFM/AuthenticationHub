using Microsoft.AspNetCore.Identity;
using System;

namespace Authentication.Core.Exceptions
{
    public class InvalidTokenException : Exception
    {
        public IdentityError Error { get; set; }

        public InvalidTokenException(string message) : base(message) { }

        public InvalidTokenException(IdentityError error, string message) : base(message)
        {
            Error = error;
        }
    }
}
