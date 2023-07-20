using System;
using System.Collections.Generic;

namespace SOLIDPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateArea calculateArea = new CalculateArea();

            double squareArea = calculateArea.CalculateSquareArea(8);
            Console.WriteLine($"Square Area: {squareArea}");

            double rectangleArea = calculateArea.CalculateRectangleArea(7, 9);
            Console.WriteLine($"Rectangle Area: {rectangleArea}");

            double circleArea = calculateArea.CalculateCircleArea(6);
            Console.WriteLine($"Circle Area: {circleArea}");

            double triangleArea = calculateArea.CalculateTriangleArea(5,3);
            Console.WriteLine($"Triangle Area: {triangleArea}");
        }
    }
}

// All methods in the class are responsible for a single shape to calculate, and the class is only responsible for calculating.
public class CalculateArea
{
    public double CalculateSquareArea(double side)
    {
        return side * side;
    }

    public double CalculateRectangleArea(double width, double length)
    {
        return width * length;
    }

    public double CalculateCircleArea(double r)
    {
        return Math.PI * r * r;
    }

    public double CalculateTriangleArea(double baseLength, double height)
    {
        return (baseLength * height) / 2;
    }
}

