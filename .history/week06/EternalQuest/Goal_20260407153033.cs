public class Goal
{
    private string _description;
    private int _status;
    private int _setPoints;
    private int _setPeriod;
    private int _currentPoints;
    private int _eventCount;
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
    public int GetCurrentPoints()
    {
        return _currentPoints += _setPoints*_status;
    }
    public int GetEventCount()
    {
        return _eventCount += _status;
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