public class Job
{
    public string _company;
    public string _jobTitle;
    public Job()
    {
        _company = "Microsoft";
        _jobTitle = "Software Engineer";
        Console.WriteLine($"I work at {_company} as a {_jobTitle}.");
    }
}