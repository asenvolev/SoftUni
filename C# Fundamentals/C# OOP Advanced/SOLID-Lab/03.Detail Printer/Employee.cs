﻿namespace _03.Detail_Printer
{
    using System;
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public override string ToString()
        {
            return $"Name: {this.Name}";
        }
    }
}