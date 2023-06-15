using System;
using NUnit.Framework;

namespace MyTestProject
{
    [TestFixture]
    class CalcTest
    {
        [Test]
        public void AddTest()
        {
            // Create an instance of the Calc class
            Calc c = new Calc();

            // Set the values of x and y
            double x = 4.0;
            double y = 5.0;

            // Set the expected value of the addition
            double expectedValue = 5.0;

            // Perform the addition and get the actual value
            double actualValue = c.Add(x, y);

            // Check if the actual value matches the expected value
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void SubTest()
        {
            // Create an instance of the Calc class
            Calc c = new Calc();

            // Set the values of x and y
            double x = 9.0;
            double y = 5.0;

            // Set the expected value of the addition
            double expectedValue = 2.0;

            // Perform the addition and get the actual value
            double actualValue = c.Sub(x, y);

            // Check if the actual value matches the expected value
            Assert.AreEqual(expectedValue, actualValue);
        }
    }


}
