public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Video> _videos;
    public Video()
    {
        _title = "The Great Apostacy";
        _author = "Jeffrey R. Holland";
        _lengthInSeconds = 3600;
    }
    public void AddVideo()
    {
        _videos.Add();
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
    }

}