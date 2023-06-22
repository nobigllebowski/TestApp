using TestApp;

namespace Unit.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateCircleArea()
        {
            Circle circle = new(5);

            double expected = Math.PI * 5 * 5;
            double result = circle.CalculateArea();

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CalculateTriangleArea()
        {
            Triangle triangle = new(3, 4, 5);

            double expected = 6;
            double result = triangle.CalculateArea();

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CheckTriangleRight()
        {
            Triangle triangle = new(3, 4, 5);

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.That(isRightTriangle);
        }
    }
}