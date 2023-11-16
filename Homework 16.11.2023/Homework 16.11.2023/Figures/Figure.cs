using System;

public abstract class Figure
{
    private string color;
    private bool isVisible;

    public Figure(string color, bool isVisible)
    {
        this.color = color;
        this.isVisible = isVisible;
    }

    public virtual void MoveHorizontal(int distance)
    {
        Console.WriteLine($"Moving {GetType().Name} horizontally by {distance} units.");
    }

    public virtual void MoveVertical(int distance)
    {
        Console.WriteLine($"Moving {GetType().Name} vertically by {distance} units.");
    }

    public void ChangeColor(string newColor)
    {
        color = newColor;
        Console.WriteLine($"Changing {GetType().Name} color to {color}.");
    }

    public bool IsVisible
    {
        get { return isVisible; }
        set { isVisible = value; }
    }

    public virtual void Display()
    {
        Console.WriteLine($"Figure Type: {GetType().Name}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Visibility: {isVisible}");
    }
}