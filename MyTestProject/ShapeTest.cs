using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{

    [TestFixture]
    public class ShapeTest
    {
        [Test]
        public void Circle_Area_CalculatedCorrectly()
        {
            Circle circle = new Circle(5);

            // Verify that the area calculations for the circle are correct
            Assert.AreEqual(78.53981633974483, circle.CalculateArea(), 0.0001);
        }

        [Test]
        public void Rectangle_Area_CalculatedCorrectly()
        {
            Rectangle rectangle = new Rectangle(4, 6);

            // Verify that the area calculations for the rectangle are correct
            Assert.AreEqual(24, rectangle.CalculateArea());
        }

        [Test]
        public void Triangle_Area_CalculatedCorrectly()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            // Verify that the area calculations for the triangle are correct
            Assert.AreEqual(6, triangle.CalculateArea());
        }

        [Test]
        public void Circle_Perimeter_CalculatedCorrectly()
        {
            Circle circle = new Circle(5);

            // Verify that the perimeter calculations for the circle are correct
            Assert.AreEqual(31.41592653589793, circle.CalculatePerimeter(), 0.0001);
        }

        [Test]
        public void Rectangle_Perimeter_CalculatedCorrectly()
        {
            Rectangle rectangle = new Rectangle(4, 6);

            // Verify that the perimeter calculations for the rectangle are correct
            Assert.AreEqual(20, rectangle.CalculatePerimeter());
        }

        [Test]
        public void Triangle_Perimeter_CalculatedCorrectly()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            // Verify that the perimeter calculations for the triangle are correct
            Assert.AreEqual(12, triangle.CalculatePerimeter());
        }
    }
}
