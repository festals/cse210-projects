public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected int _totalDuration;

    public Activity()
    {
       _name = "";
       _description = "";
       _duration = 0;
       _totalDuration =0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        _duration = Int32.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(2);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n \nWell done!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add(@"\");
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

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

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        } 
    }

    public int GetTotalDuration()
    {
        return _totalDuration;
    }

}