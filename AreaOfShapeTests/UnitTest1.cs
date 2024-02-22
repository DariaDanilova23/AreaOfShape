using AreaOfShape;

namespace AreaOfShapeTests
{
    public class CircleTests
    {
        private Circle circle;
        [SetUp]
        public void Setup()
        {
            circle=new Circle(5);
        }

        [Test]
        public void CalculateAreaTest()
        {
            double expectedArea = Math.PI * 25;
            double actualArea = circle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }
    }

    public class TriangleTests
    {
        Triangle triangle;
        [SetUp]
        public void Setup()
        {
            triangle = new Triangle(3, 4, 5);
        }

        [Test]
        public void CalculateAreaTest()
        {
            double expectedArea = 6;
            double actualArea = triangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void IsRightAngledTriangle()
        {
            bool isRightAngled = triangle.IsRightAngledTriangle();

            Assert.IsTrue(isRightAngled);

        }
    }

    public class RectangleTests
    {
        Rectangle rectangle;
        [SetUp]
        public void Setup()
        {
            rectangle = new Rectangle(5, 7);
        }

        [Test]
        public void CalculateAreaTest()
        {
            double expectedArea= 35.0; 
            double actualArea = rectangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }
    }
}