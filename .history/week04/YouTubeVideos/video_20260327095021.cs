public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _title = "Great Apostacy";
        _author = "Elder Jeffrey R. Holland";
        _lengthInSeconds = 3600;
    }
    

}