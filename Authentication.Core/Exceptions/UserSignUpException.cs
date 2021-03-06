﻿using Microsoft.AspNetCore.Identity;
using System;

namespace Authentication.Core.Exceptions
{
    public class UserSignUpException : Exception
    {
        public IdentityError Error { get; set; }

        public UserSignUpException(IdentityError error, string message) : base (message) 
        {
            this.Error = error;
        }
    }
}
