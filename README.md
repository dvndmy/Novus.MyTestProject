# Shape Calculator

This is a C# program that calculates the area and perimeter of different shapes, including a circle, rectangle, and triangle. The program consists of four classes: Circle, Rectangle, Triangle, and ShapeTest.

## Classes

### Circle
The Circle class represents a circle shape. It has a constructor that takes the radius as a parameter. The class provides methods to calculate the area and perimeter of the circle using the appropriate formulas.

### Rectangle
The Rectangle class represents a rectangle shape. It has a constructor that takes the length and width as parameters. The class provides methods to calculate the area and perimeter of the rectangle using the appropriate formulas.

### Triangle
The Triangle class represents a triangle shape. It has a constructor that takes the lengths of the three sides as parameters. The class provides methods to calculate the area and perimeter of the triangle using the Heron's formula and the sum of the side lengths.

### ShapeTest
The ShapeTest class contains NUnit test methods to verify the correctness of the area and perimeter calculations for each shape. It uses the Assert class from NUnit.Framework to compare the expected results with the actual results obtained from the shape objects.

## Usage
1. Ensure that the NUnit framework is installed.
2. Compile and run the program.
3. The program will execute the tests in the ShapeTest class and display the test results.
   - If all the tests pass, it means that the area and perimeter calculations are correct for the shapes.
   - If any test fails, it indicates an issue with the calculations.

## Requirements
- .NET Framework (compatible with the version used in the code)
- NUnit framework (compatible with the version used in the code)

## How it Works
- Each shape class (Circle, Rectangle, Triangle) encapsulates the logic to calculate the area and perimeter of the corresponding shape.
- The ShapeTest class verifies the correctness of these calculations using NUnit assertions.
- The program provides a modular and testable solution to calculate the areas and perimeters of different shapes.

Feel free to use the Shape Calculator program to calculate the areas and perimeters of circles, rectangles, and triangles. Enjoy!
