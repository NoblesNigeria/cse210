using System.Runtime.InteropServices;

public class Shape
{
    private string _color;
    public string color
    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}