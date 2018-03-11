﻿using System;

namespace BashSoft.Exceptions
{
    public class InvalidQueryComparison : Exception
    {
        private const string InvalidQuery = "The comparison query you want, does not exist in the context of the current program!";

        public InvalidQueryComparison() : base(InvalidQuery)
        {
        }

        public InvalidQueryComparison(string message) : base(message)
        {
        }
    }
}