using System.Runtime.InteropServices;

public abstract class Shape
{
    private string _color;
    public ComVisibleAttribute Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}