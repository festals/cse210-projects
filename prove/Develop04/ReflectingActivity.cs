public class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 50;
        _prompts = new List<string>();
        _questions = new List<string>();
        _totalDuration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        //add to totalDuration for final stat
        _totalDuration += _duration;

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.Write("\nWhen you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        DisplayQuestions();

        DisplayEndingMessage();
    }

     public string GetRandomPrompt()
        {
            _prompts.Add("Think of a time you did something really difficult.");
            _prompts.Add("Think of a time you solve a problem.");
            _prompts.Add("Think of a time you were really nervous about a task.");
            _prompts.Add("Think of a time you almost give up.");
            _prompts.Add("Think of a time you learn a difficult skill.");
            _prompts.Add("Think of a time you overcame an obstacle.");
            _prompts.Add("Think of a time your faith wavered.");

            Random random = new Random();
            int index = random.Next(_prompts.Count);
            string randomString = _prompts[index];
            
            return randomString;
        }

         public string GetRandomQuestions()
        {
            _questions.Add("How did you feel when it was complete? ");
            _questions.Add("What is your favorite thing about this experience? ");
            _questions.Add("What did you learn from this experience? ");
            _questions.Add("If you could have a do over what would you do differently? ");
            _questions.Add("How this experience made you a better person? ");
            _questions.Add("How Jesus helped you in this experience? ");
            _questions.Add("What blessing do you have in your life thanks to that experience? ");

            Random random = new Random();
            int index = random.Next(_questions.Count);
            string randomString = _questions[index];
            
            return randomString;
        }

        public void DisplayPrompt()
        {
            Console.WriteLine();
            Console.Write($"---{GetRandomPrompt()}---");
            Console.WriteLine();
        }

        public void DisplayQuestions()
        {
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);
            while(DateTime.Now< futureTime)
            {
                Console.Write($"\n> {GetRandomQuestions()}");
                ShowSpinner(8);
            }
        }
}