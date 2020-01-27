using ShapeLib.Processor.Circle;
using ShapeLib.Processor.Triangle;

namespace ShapeLib.Processor
{
    internal interface IProcessor
    {
        ITriangleProcessor TriangleProcessor { get; }
        ICircleProcessor CircleProcessor { get; }
    }
}