﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartegyPattern
{
    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Age.CompareTo(y.Age);
            return result;
        }
    }
}
