//  exceeding requierement I add a 5. enter in menu 'save and replace' (erase the data in the file before saving)
//  when you load journal and write data before saving
//  which differ from 4. 'save and add' who only append all datas of journal in file 

using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        string answer;   //answer to the menu
        Journal journal1 = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");  // ask question and memorize answer at end of journal 
            Console.WriteLine("2. Display");    // display entries of the journal
            Console.WriteLine("3. Load");       // load all entries from a file to the beginning of the journal
            Console.WriteLine("4. Save (add)");   //save (add) the new journal in the file you choose 
            Console.WriteLine("5. Save after loading (replace)");    //save erase 
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();

            // write 
            if (answer == "1")
            {
                Entry entry1 = new Entry();
                string txtPrompt;

                PromptGenerator prompt1 = new PromptGenerator();
                txtPrompt = prompt1.GetRandomPrompt();
                Console.WriteLine(txtPrompt);
                entry1._entryText = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry1._date = dateText;
                entry1._promptText = txtPrompt;

                journal1.AddEntry(entry1);

                entry1 = null;
            }

            // display
            else if (answer == "2")
            {
                
                journal1.DisplayAll();
                
            }

            // load 
            else if (answer == "3")
           {
               Console.Write("From which file do you want to load? ");
               string fileName = Console.ReadLine();
               journal1.ClearEntry();
               journal1.LoadFromFile(fileName, journal1);
               Console.WriteLine($"The file {fileName} is loaded");
            }

            //save add
            else if(answer == "4")
            {
                Console.Write("In which file do you want to save it (append) (journal.txt already exists)? ");
                string fileName = Console.ReadLine();
                journal1.SaveToFile(fileName);
                Console.WriteLine($"The journal is saved in {fileName}");
            }

            //save replace
            else if(answer == "5")
            {
                Console.Write("In which file do you want to save it (replace)? ");
                string fileName = Console.ReadLine();
                journal1.SaveToFileReplace(fileName);
                Console.WriteLine($"The journal is saved in {fileName}");
            }


        } while (answer != "6");

    }
}