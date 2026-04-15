public class Running : Sport
{
    private double _distance;
    public Running(string name, int date, int duration, double distance) : base(name, date, duration)
    {
        _distance = distance;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"Sport: {GetName()}, Date: {GetDate()}, Duration: {GetDuration()} minutes, Distance: {_distance} km", s);
    }
}