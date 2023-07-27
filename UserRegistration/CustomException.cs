﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CustomException : Exception
    {

        public enum ExceptionType
        {
            NULL_INPUT,
            EMPTY_INPUT,
            INVALID_INPUT
        }
         private readonly ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }


    }
}
