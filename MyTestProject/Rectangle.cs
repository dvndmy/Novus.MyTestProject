using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    // Rectangle class
    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            // Calculate the area of the rectangle by multiplying its length and width
            return length * width;
        }

        public double CalculatePerimeter()
        {
            // Calculate the perimeter of the rectangle using the formula: 2 * (length + width)
            return 2 * (length + width);
        }
    }

    

}
