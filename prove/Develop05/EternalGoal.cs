public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points): base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void SetComplete(int complete)
    {
        return;
    }


    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName} ({_description})";
    }

    public override string GetStringCsv()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}";  
    }
}