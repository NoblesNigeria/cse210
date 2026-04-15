public class Cycling : Sport
{
    private double _speed;
    private double _distance;
    public Cycling(string name, int date, int duration, double distance, double speed) : base(name, date, duration)
    {
        _speed = speed;
        _distance = distance;
    }
    public double GetSpeed()
    {
        return _speed = _distance / (GetDuration() / 60.0);
    }
    public double GetDistance()
    {
        return _distance;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"Sport: {GetName()}, Date: {GetDate()}, Duration: {GetDuration()} minutes, Speed: {_speed} km/h", distance);
    }
}