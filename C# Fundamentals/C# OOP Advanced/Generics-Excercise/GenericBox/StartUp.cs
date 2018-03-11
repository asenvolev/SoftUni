using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBox
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = 123123;
            string something = "Life in a box";
            var box = new Box<int>(number);
            var boxx = new Box<string>(something);
            Console.WriteLine(box);
            Console.WriteLine(boxx);
        }
    }
}
