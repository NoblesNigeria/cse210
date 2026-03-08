using System.Security.Cryptography.X509Certificates;

public class Resume
{
    public string _name;
    public List<Resume> _resumes;

    public Resume()
    {
        _name = "John Doe";
        _resumes = new List<Resume>();
        Resume._resumes.Add(new Resume("Software Engineer"));
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