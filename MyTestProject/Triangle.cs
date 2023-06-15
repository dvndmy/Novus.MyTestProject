using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    // Triangle class
    public class Triangle
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            // Calculate the area of the triangle using Heron's formula
            // Area = √(s * (s - a) * (s - b) * (s - c))
            // where s is the semi-perimeter and a, b, c are the sides of the triangle
            double semiPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public double CalculatePerimeter()
        {
            // Calculate the perimeter of the triangle by summing its three sides
            return side1 + side2 + side3;
        }
    }

    
}
