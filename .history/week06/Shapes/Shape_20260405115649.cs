public abstract class Shape
{
    private string _color;
    public abstract Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}