using System.Linq.Expressions;

public class BreathingActivity: Activity
{
    public BreathingActivity()
    {
        _name = "Breating";
        _description = "This activity will help you relax by walking you through bretaing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 50;
    }

    public void Run()
    {


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DisplayStartingMessage();

        while(DateTime.Now < futureTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("Now breathe out...\n");
            ShowCountDown(4);
        }  

        DisplayEndingMessage();  
    }
        
}