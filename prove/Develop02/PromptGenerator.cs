using System.ComponentModel;
public class PromptGenerator
{
    public List<string> prompts = new List<string>();

        public string GetRandomPrompt()
        {
            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
            prompts.Add("What blessing did I saw today?");
            prompts.Add("What made me laugh today?");
            prompts.Add("What the most beautiful thing I saw Today?");
            prompts.Add("What did I learn about Jesus today?");
            prompts.Add("How did I stay poisitive today? (If not what should I have done)");
            prompts.Add("Who did I keep in my prayer today?");
            prompts.Add("What am I thankfull for today?");

            Random random = new Random();
            int index = random.Next(prompts.Count);
            string randomString = prompts[index];
            

            return randomString;
        }
}