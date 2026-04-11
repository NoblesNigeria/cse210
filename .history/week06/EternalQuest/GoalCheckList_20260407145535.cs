public class Goal
{
    private string _description;
    private string _status;
    private int _setPoints;
    private int _setPeriod;
    public Goal(string description, string status, int setPoints, int setPeriod)
    {
        _description = description;
        _status = status;
        _setPoints = setPoints;
        _setPeriod = setPeriod;
    }
    
}