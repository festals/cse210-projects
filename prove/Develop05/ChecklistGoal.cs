public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        if(_amountCompleted == _target)
        {
            return true;
        }

        return false;
    }

    public override void SetComplete(int complete)
    {
        _amountCompleted = complete;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }

    public override string GetStringRepresentation()
    {
        string txtComplete = " ";

        if( IsComplete() == true)
        {
            txtComplete= "X";   
        }

        return $"[{txtComplete}] {_shortName} ({_description}) --completed {_amountCompleted}/{_target}";
    }

    public override string GetStringCsv()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";  
    }
}