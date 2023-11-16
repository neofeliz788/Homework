using System;

public class Circle : Point
{
    private double radius;

    public Circle(string color, bool isVisible, double radius) : base(color, isVisible)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Radius: {radius}");
    }
}
