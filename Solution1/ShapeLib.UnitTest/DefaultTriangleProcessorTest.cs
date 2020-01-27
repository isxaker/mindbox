using System;
using NUnit.Framework;
using ShapeLib.Processor.Triangle;

namespace ShapeLib.UnitTest
{
    [TestFixture]
    internal sealed class DefaultTriangleProcessorTest
    {
        private readonly DefaultTriangleProcessor _processor = new DefaultTriangleProcessor();

        [Test]
        [TestCase(3d, 4d, 5d, 6d)]
        [TestCase(6d, 8d, 10d, 24d)]
        public void Ok(double a, double b, double c, double expected)
        {
            var result = _processor.Square(a, b, c);
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        [TestCase(-3d, 4d, 5d, "a")]
        [TestCase(3d, -4d, 5d, "b")]
        [TestCase(3d, 4d, -5d, "c")]
        public void Fail(double a, double b, double c, string failedParam)
        {
            var error = Assert.Throws<ArgumentException>(() => _processor.Square(a, b, c));
            Assert.AreEqual(error.ParamName, failedParam);
        }
    }
}