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
    public string getName()
    {
        return _name;
    }
    public int getDate()
    {
        return _date;
    }
    public int getDuration()
    {
        return _duration;
    }
    public virtual 
}