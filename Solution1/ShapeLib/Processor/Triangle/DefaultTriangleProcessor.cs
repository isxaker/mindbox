using System;
using ShapeLib.Errors;
using ShapeLib.Properties;

namespace ShapeLib.Processor.Triangle
{
    internal class DefaultTriangleProcessor : ITriangleProcessor
    {
        public double Square(double a, double b, double c)
        {
            Verifiers.ArgVerify(a > 0d, Resources.ErrorMsgValueCanNotBeLessOrEqualToZero, nameof(a));
            Verifiers.ArgVerify(b > 0d, Resources.ErrorMsgValueCanNotBeLessOrEqualToZero, nameof(b));
            Verifiers.ArgVerify(c > 0d, Resources.ErrorMsgValueCanNotBeLessOrEqualToZero, nameof(c));

            var p = a + b + c;
            var s = (a + b + c) / 2d; // Perimeter/2
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }
    }
}