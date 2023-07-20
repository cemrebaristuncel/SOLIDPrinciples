using System;
using System.Collections.Generic;

namespace SOLIDPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Side = 5;
            double squareArea = square.CalculateArea(); // Output is 25

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 8;
            double rectangleArea = rectangle.CalculateArea(); // Output is 40

            Circle circle = new Circle();
            circle.Radius = 4;
            double circleArea = circle.CalculateArea(); // Output is 50.26548245743669

            Console.WriteLine("Area of square is : " + squareArea);
            Console.WriteLine("Area of rectangle is : " + rectangleArea);
            Console.WriteLine("Area of circle is : " + circleArea);
        }
    }
}

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}


