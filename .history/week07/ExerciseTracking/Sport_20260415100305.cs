public class Sport
{
    private string _name;
    private int _date;
    private int _duration;
    public Sport(string name, int date, int duration)
    {
        _name = name;
        _date = date;
        _duration = duration;
    }
    public string etName()
    {
        return _name;
    }
    public int getDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public virtual void GetSummary()
    {
        Console.WriteLine($"Sport: {_name}, Date: {_date}, Duration: {_duration} minutes");
    }
}