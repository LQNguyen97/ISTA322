using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticProperties
{
    class Program
    {
        static void doWork()
        {
            Polygon square = new Polygon();
            Polygon triangle = new Polygon { NumSides = 3 };
            Polygon pentagon = new Polygon { SideLength = 15.5, NumSides = 5 };
            Polygon octogon = new Polygon { SideLength = 12, NumSides = 8 };
            Console.WriteLine($"Square: number of sides is {square.NumSides}, length of each side is { square.SideLength }");
            Console.WriteLine($"Triangle: number of sides is {triangle.NumSides}, length of each side is { triangle.SideLength }");
            Console.WriteLine($"Pentagon: number of sides is {pentagon.NumSides}, length of each side is { pentagon.SideLength }");
            Console.WriteLine($"octgon: number of sides is {octogon.NumSides}, length of each side is { octogon.SideLength }");
        }

        static void Main(string[] args)
        {
                doWork();
        }
    }
}

