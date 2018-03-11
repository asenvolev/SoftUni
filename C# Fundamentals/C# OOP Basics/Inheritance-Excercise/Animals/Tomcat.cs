﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat:Animal
    {
        public const string Gender = "Male";
        public Tomcat(string name, int age)
            :base(name,age,Gender)
        {

        }

        public override string ProduceSound()
        {
            return "Give me one million b***h";
        }
    }
}
