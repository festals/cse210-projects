public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name,string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual void SetComplete(int complete)
    {

    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();

    public abstract string GetStringCsv();

    public string GetName()
    {
        return _shortName; 
    } 
       
    public string GetPoints()
    {
        return _points;
    }
}