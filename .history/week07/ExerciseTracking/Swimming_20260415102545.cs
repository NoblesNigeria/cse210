public class Swimming : Sport
{
    private double _distance;
    private double _laps;
    public Swimming(string name, int date, int duration, double distance) : base(name, date, duration)
    {
        _distance = distance;
    }
    public double GetDistance()
    {
        return _distance = _laps * 50 / 1000;
    }
    public double GetLaps()
    {
        return _laps = _distance / 0.05;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"Sport: {GetName()}, Date: {GetDate()}, Duration: {GetDuration()} minutes, Distance: {_distance} km, Laps: {GetLaps()}");
    }
}