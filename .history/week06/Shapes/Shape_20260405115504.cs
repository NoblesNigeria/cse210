public virtual class Shape
{
    private string _color;
    public virtShape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}