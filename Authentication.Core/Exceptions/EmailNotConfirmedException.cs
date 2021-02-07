﻿using System;

namespace Authentication.Core.Exceptions
{
    public class EmailNotConfirmedException : Exception
    {
        public EmailNotConfirmedException(string message) : base(message) { }
    }
}
