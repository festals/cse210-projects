using System.ComponentModel;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

        public string GetRandomPrompt()
        {
            _prompts.Add("What blessing did I saw today?");
            _prompts.Add("What made me laugh today?");
            _prompts.Add("What the most beautiful thing I saw Today?");
            _prompts.Add("What did I learn about Jesus today?");
            _prompts.Add("How did I stay positive today? (If not what should I have done)");
            _prompts.Add("Who did I keep in my prayer today?");
            _prompts.Add("What am I thankfull for today?");

            Random random = new Random();
            int index = random.Next(_prompts.Count);
            string randomString = _prompts[index];
            
            return randomString;
        }
}