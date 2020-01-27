using ShapeLib.Errors;
using ShapeLib.Processor;

namespace ShapeLib.Interfaces
{
    public interface IShapeCalculator
    {
        double CircleSquare(double radius);
        double TriangleSquare(double a, double b, double c);
    }
    
    public class ShapeCalculator : IShapeCalculator
    {
        private readonly IProcessor _processor = ProcessorFactory.Create();

        public double CircleSquare(double radius)
        {
            Verifiers.ArgVerify(radius > 0d, Properties.Resources.ErrorMsgValueCanNotBeLessOrEqualToZero, nameof(radius));
            return _processor.CircleProcessor.Square(radius);
        }

        public double TriangleSquare(double a, double b, double c)
        {
            Verifiers.ArgVerify(a > 0d, Properties.Resources.ErrorMsgValueCanNotBeLessOrEqualToZero, nameof(a));
            Verifiers.ArgVerify(b > 0d, Properties.Resources.ErrorMsgValueCanNotBeLessOrEqualToZero, nameof(b));
            Verifiers.ArgVerify(b > 0d, Properties.Resources.ErrorMsgValueCanNotBeLessOrEqualToZero, nameof(c));

            return _processor.TriangleProcessor.Square(a, b, c);
        }
    }
}