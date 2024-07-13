public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base (name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    // 
    {
        _isComplete = true;

        Console.WriteLine($"\nCongratulations! you have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void SetComplete(int complete)
    {
        _isComplete = false;

        if (complete == 1)
        {
            _isComplete = true;
        }

    }

    public override string GetStringRepresentation()
    {
        string txtComplete = " ";

        if( IsComplete() == true)
        {
            txtComplete= "X";   
        }

        return $"[{txtComplete}] {_shortName} ({_description})";  
    }

    public override string GetStringCsv()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";  
    }

}