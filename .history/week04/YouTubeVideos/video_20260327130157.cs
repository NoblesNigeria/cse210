public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Video> _videoTracker;
    public Video()
    {
        _title = "The Great Apostacy";
        _author = "Jeffrey R. Holland";
        _lengthInSeconds = 3600;
        _title = ""
    }
    public List<Video> AddVideo(string title, string author, int lengthInSeconds)
    {
        if (_videoTracker == null)
        {
            _videoTracker = new List<Video>();

        }
        _videoTracker.Add(new Video());

        return _videoTracker;

    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine("Video added to tracker.");
        Console.WriteLine(AddVideo(_title, _author, _lengthInSeconds));
    }

}