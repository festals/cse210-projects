using System;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        bool flagMenu = true;
        GoalManager myManager = new GoalManager();

        Console.Clear();

        do
        {
            
            if (flagMenu == false)
            {
                Console.WriteLine("You can only type 1, 2, 3, 4, 5 or 6");
            }

            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");  // 
            Console.WriteLine("     2. List Goals");    // 
            Console.WriteLine("     3. Save Goals");       // 
            Console.WriteLine("     4. Load Goals");       // 
            Console.WriteLine("     5. Record Events");       // 
            Console.WriteLine("     6. Quit");   //
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();
            flagMenu = true;

            if (answer == "1")
            {
                myManager.CreateGoal();
            }

            else if (answer == "2")
            {
                myManager.ListGoalDetails();
            }

            else if (answer == "3")
            {
                myManager.SaveGoal();
            }

            else if (answer == "4")
            {
                myManager.LoadGoal();
            }

            else if (answer == "5")
            {
                myManager.RecordEvent();
            }


            else if (answer != "6")
            {
                flagMenu = false;

            }

        } while (answer != "6");
    }
}



