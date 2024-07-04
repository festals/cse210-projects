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
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.WriteLine($"How long, in seconds, would you like for your session? ");
        _duration = Int32.Parse(Console.ReadLine());

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} of the {_name} Activity.");

    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        do
        {
            Console.Write("/");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character


            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write(@"\");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("|");

        }while(startTime > futureTime);    
    }

    public void ShowCountDown(int seconds)
    {
        
    }
}