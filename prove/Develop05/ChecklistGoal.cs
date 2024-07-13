using System.Text;

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
        _amountCompleted = 0;        //combien de fois le goal a été rempli et inf à target
    }

    public override void RecordEvent()
    {

        // ajouter +1 _amountCompleted
        _amountCompleted ++;

        //      si accomplish the totaly of the goal 
        if (_amountCompleted == _target)
        {
            // ajouter le bonus
            _points = (Int32.Parse(_points) +_bonus).ToString();

            // et valider isComplete inutile parce que Iscomplet est vrai qd _amountCompleted = _target

            // display star for 10 second 
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(10);

            Console.OutputEncoding = Encoding.UTF8;
            Console.Write($"\nCongratulation! You have completed your Checklist Goal! ");

            List<string> animationStrings = new List<string>();
            animationStrings.Add("★");
            animationStrings.Add("*");
            
            do
            {
                foreach (string s in animationStrings)
                {
                    if(DateTime.Now >= futureTime)
                    {
                        break;
                    }
                    Console.Write(s);
                    Thread.Sleep(700);
                    Console.Write("\b \b");
                }
            }while(DateTime.Now < futureTime);
        }

        Console.WriteLine($"\nCongratulations! you have earned {_points} points!\n");
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
    // menu 4 load set amountComplete : (si amountComplete = target alors IsComplete)
    // menu 5 record event modidfy amountComplete
    {
        _amountCompleted = complete;
    }

    public override string GetDetailsString()
    // get amount target bonus in string (csv) 
    // menu 5 record event
    {
        //return $"--Currently completed: {_amountCompleted}/{_target}";
        return $"{_amountCompleted},{_target},{_bonus}";
    }

    public override string GetStringRepresentation()
    // display list (menu 2)
    {
        string txtComplete = " ";

        if( IsComplete() == true)
        {
            txtComplete= "X";   
        }

        return $"[{txtComplete}] {_shortName} ({_description}) --Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringCsv()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";  
    }
}