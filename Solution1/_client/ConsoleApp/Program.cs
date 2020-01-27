using System;
using ShapeLib.Interfaces;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            var shapeCalculator = new ShapeCalculator();
            Console.WriteLine(shapeCalculator.CircleSquare(9.11d));
            Console.WriteLine(shapeCalculator.TriangleSquare(3d, 5d, 7d));

            Console.ReadKey();
        }
    }
}