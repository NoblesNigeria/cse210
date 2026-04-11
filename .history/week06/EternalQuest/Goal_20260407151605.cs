public class Goal
{
    private string _description;
    private int _status;
    private int _setPoints;
    private int _setPeriod;
    pri
    public Goal(string description, int status, int setPoints, int setPeriod)
    {
        _description = description;
        _status = status;
        _setPoints = setPoints;
        _setPeriod = setPeriod;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetStatus()
    {
        return _status;
    }
    public int GetSetPoints()
    {
        return _setPoints;
    }
    public int GetSetPeriod()
    {
        return _setPeriod;
    }


}