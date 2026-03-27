Seconds = 3600;
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