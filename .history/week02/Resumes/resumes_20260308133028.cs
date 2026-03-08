public class Resume
{
    public string _name;
    public List<Job> _jobs;
    public Resume()
    {
        _name = "John Doe";
        _jobs = new List<Job>();
        _jobs.Add(new Job("Microsoft", "Software Engineer"));
    }
}