using ShapeLib.Processor.Circle;
using ShapeLib.Processor.Triangle;

namespace ShapeLib.Processor
{
    internal class DefaultProcessor : IProcessor
    {
        public ITriangleProcessor TriangleProcessor { get; } = new DefaultTriangleProcessor();
        public ICircleProcessor CircleProcessor { get; } = new DefaultCircleProcessor();
    }
}