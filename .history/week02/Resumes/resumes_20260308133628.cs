public class Resume
{
    public string _name;
    public List<Resume> _resumes;
    public Resume()
    {
        _name = "John Doe";
        _resumes = new List<Resume>();
        _resumes.Add(new Resume("Web Developer"));
        _resumes.Add(new Resume("Software Engineer"));
    }
}