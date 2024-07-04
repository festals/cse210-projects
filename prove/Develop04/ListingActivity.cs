public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 50;
        _prompts = new List<string>();
        _count = 0;
    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {
        _prompts.Add("What blessing did I saw today?");
        _prompts.Add("What made me laugh today?");
        _prompts.Add("What beautiful things I saw Today?");
        _prompts.Add("What did I learn about Jesus today?");
        _prompts.Add("How did I stay positive today?");
        _prompts.Add("Who did I keep in my prayer today?");
        _prompts.Add("What am I thankfull for today?");


        // if we return string 
        //Random random = new Random();
        //int index = random.Next(_prompts.Count);
        
        //string randomString = _prompts[index];
        //return randomString;
    }

    // public List<string> GetListFromUser()
    // {

    //     return ;
    // }

}