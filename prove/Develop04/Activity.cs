public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
       _name = "";
       _description = "";
       _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Activity myActivity = new Activity(); 

        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = Int32.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...");
        myActivity.ShowSpinner(5);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
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
}