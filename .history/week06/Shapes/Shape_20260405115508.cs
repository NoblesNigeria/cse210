public virtual class Shape
{
    private string _color;
    public virtualShape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}