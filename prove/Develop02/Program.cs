using System;

class Program
{
    static void Main(string[] args)
    {
        string answer;   //answer to the menu
        Journal journal1 = new Journal();
        Entry entry1 = new Entry();
        //string entries = "";     // response to the prompt question

        do
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");  // ask question and memorize answer at end of journal 
            Console.WriteLine("2. Display");    // display entries of the journal
            Console.WriteLine("3. Load");       // load all entries from a file to the beginning of the journal
            Console.WriteLine("4. Save");   //save the new journal in the file you choose
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            answer = Console.ReadLine();

            // write 
            if (answer == "1")
            {
                string txtPrompt;
                PromptGenerator prompt1 = new PromptGenerator();
                txtPrompt = prompt1.GetRandomPrompt();
                Console.WriteLine(txtPrompt);
                entry1._entryText = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry1._date = dateText;
                entry1._promptText = txtPrompt;

                entry1.DisplayEntry();
            }

            // display
            else if (answer == "2")
            {
                
                journal1.DisplayAll();
                
            }

            // load 
            //else if (answer == "3")
           // {
           //     Journal.LoadFromFile("file.txt");
            //}

            // save 
            //else if(answer == "4")
            //{
            //    Journal.SaveToFile();
            //}


        } while (answer != "5");

    }
}