using NUnit.Framework;
using System;

// Circle class
public class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        // Calculate the area of the circle using the formula: π * r^2
        return Math.PI * radius * radius;
    }

    public double CalculatePerimeter()
    {
        // Calculate the perimeter of the circle using the formula: 2 * π * r
        return 2 * Math.PI * radius;
    }
}

