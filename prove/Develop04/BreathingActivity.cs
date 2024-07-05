using System.Linq.Expressions;

public class BreathingActivity: Activity
{
    public BreathingActivity()
    {
        _name = "Breating";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
        _totalDuration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        //add to totalDuration for final stat
        _totalDuration += _duration;       

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < futureTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nNow breathe out...");
            ShowCountDown(4);
        }  

        DisplayEndingMessage();  
    }
        
}