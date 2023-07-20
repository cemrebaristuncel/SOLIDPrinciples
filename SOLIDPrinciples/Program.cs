using System;
using System.Collections.Generic;

namespace SOLIDPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle { Width = 8, Height = 3 };
            Shape circle = new Circle { Radius = 6 };
            Shape square = new Square { Side = 5 };
            Shape shape = new Shape { };


            AreaOutput(rectangle); // Output : 24
            AreaOutput(circle);    // Output : 113.09733552923255
            AreaOutput(square);    // Output : 25
            AreaOutput(shape);    //  Output : 0
        }

        public static void AreaOutput(Shape shape)
        {
            double area = shape.CalculateArea();
            Console.WriteLine($"Area: {area}");
        }
    }
}

public class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
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

public class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}

