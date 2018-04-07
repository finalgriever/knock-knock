﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnock.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException()
            : base()
        {
        }

        public DomainException(string message)
            : base(message)
        {
        }

        public DomainException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}