public class Swimming : Sport
{
    private double _distance;
    private double _laps;
    public Swimming(string name, int date, int duration, double distance,) : base(name, date, duration)
    {
        _distance = distance;
    }
    public double GetDistance()
    {
        return _distance = _laps * 50 / 1000 *0.62;
    }
    public double GetLaps()
    {
        return _laps;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"Sport: {GetName()}, Date: {GetDate()}, Duration: {GetDuration()} minutes, Distance: {GetDistance()} km, Laps: {GetLaps()}");
    }
}