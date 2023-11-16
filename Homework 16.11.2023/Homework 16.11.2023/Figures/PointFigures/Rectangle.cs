using System;

public class Rectangle : Point
{
    private double width;
    private double height;

    public Rectangle(string color, bool isVisible, double width, double height) : base(color, isVisible)
    {
        this.width = width;
        this.height = height;
    }

    public double CalculateArea()
    {
        return width * height;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Width: {width}, Height: {height}");
    }
}