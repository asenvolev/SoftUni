using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());
    }
}

