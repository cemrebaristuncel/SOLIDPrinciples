using System;
using System.Collections.Generic;

namespace SOLIDPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Side = 4;
            double squareArea = square.CalculateArea();
            Console.WriteLine("Square area : " + squareArea); // 16

            Calculator calculator = new Calculator(square);
            Console.WriteLine("Square area : " + calculator.CalculateArea()); // 16

        }
    }
}



public interface IShape
{
    double CalculateArea();
}

public class Calculator
{
    private IShape _shape;

    public Calculator(IShape shape)
    {
        _shape = shape;
    }

    public double CalculateArea()
    {
        return _shape.CalculateArea();
    }
}


public class Square : IShape
{
    public double Side { get; set; }

    public double CalculateArea()
    {
        return Side * Side;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

