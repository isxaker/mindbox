using System;
using NUnit.Framework;
using ShapeLib.Processor.Circle;

namespace ShapeLib.UnitTest
{
    [TestFixture]
    public class DefaultCircleProcessorTest
    {
        private readonly DefaultCircleProcessor _processor = new DefaultCircleProcessor();

        [Test]
        [TestCase(3d, 28d)]
        [TestCase(6d, 113d)]
        public void Ok(double radius, double expected)
        {
            var result = _processor.Square(radius);
            Assert.AreEqual(expected, result, 0.5d);
        }
        
        [Test]
        [TestCase(-3d, "radius")]
        public void Fail(double radius, string failedParam)
        {
            var error = Assert.Throws<ArgumentException>(() => _processor.Square(radius));
            Assert.AreEqual(error.ParamName, failedParam);
        }
    }
}