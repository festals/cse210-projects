public class Job
{
    public string _compagny;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_compagny}) {_startYear}-{_endYear}");
    }
}

