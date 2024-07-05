public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 50;
        _count = 0;
        _totalDuration = 0;
        _prompts = new List<string>{
           "What blessing did I see today?",
           "What made me laugh today?", 
           "What beautiful things did I see Today?",
           "What did I learn about Jesus today?",
           "How did I stay positive today?",
           "Who did I keep in my prayer today?",
           "What am I thankfull for today?"
        };


        // _prompts.Add("What blessing did I saw today?");
        // _prompts.Add("What made me laugh today?");
        // _prompts.Add("What beautiful things I saw Today?");
        // _prompts.Add("What did I learn about Jesus today?");
        // _prompts.Add("How did I stay positive today?");
        // _prompts.Add("Who did I keep in my prayer today?");
        // _prompts.Add("What am I thankfull for today?");
    }

    public void Run()
    {
        List<string> userList = new List<string>();

        DisplayStartingMessage();

        //add to totalDuration for final stat
        _totalDuration += _duration;

        Console.WriteLine("List as many responses you can, to the following prompt:");

        // write random prompt
        GetRandomPrompt();

        // time for reflection
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);

        // for the duration of the activity you can type responses until no more time
        Console.WriteLine();
        userList = GetListFromUser();

        _count = userList.Count();

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    // select a random prompt from a list of prompt
    // and write it
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        Console.WriteLine($"\n---{_prompts[index]}---");        
    }

    public List<string> GetListFromUser()
    //get element of the items the user wrote put them in this list
    {
        List<string> userList = new List<string>();

        // loop while duration
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < futureTime)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        } 

        return userList;
    }

}