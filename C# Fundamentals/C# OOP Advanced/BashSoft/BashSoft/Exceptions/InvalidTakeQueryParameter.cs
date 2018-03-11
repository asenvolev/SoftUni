﻿using System;

namespace BashSoft.Exceptions
{
    public class InvalidTakeQueryParameter : Exception
    {
        private const string InvalidTakeQueryParamter = "The take command expected does not match the format wanted!";

        public InvalidTakeQueryParameter() : base(InvalidTakeQueryParamter)
        {
        }

        public InvalidTakeQueryParameter(string message) : base(message)
        {
        }
    }
}