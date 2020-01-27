using System;
using ShapeLib.Errors;
using ShapeLib.Properties;

namespace ShapeLib.Processor.Circle
{
    internal class DefaultCircleProcessor : ICircleProcessor
    {
        public double Square(double radius)
        {
            Verifiers.ArgVerify(radius > 0d, Resources.ErrorMsgValueCanNotBeLessOrEqualToZero, nameof(radius));

            var area = Math.PI * radius * radius;
            return area;
        }
    }
}