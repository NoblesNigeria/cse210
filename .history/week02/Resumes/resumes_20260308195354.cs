public class Resume
{
    public string _name;
    public List<Resume> _resumes;
    public Resume()
    {
        _name = "John Doe";
        Public <Li_resumes = new List<Resume>();
    }
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Resumes:");
        foreach (var resume in _resumes)
        {
            resume.Display();
        }
    }
}