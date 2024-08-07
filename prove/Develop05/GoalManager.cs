using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {


    }

    public void Start()
    // menu principal
    {
        string answer;
        bool flagMenu = true;

        do
        {
            
            if (flagMenu == false)
            {
                Console.WriteLine("You can only type 1, 2, 3, 4, 5 or 6");
            }
            
            DisplayPlayerInfo();
            
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
                CreateGoal();
            }

            else if (answer == "2")
            {
                ListGoalDetails();
            }

            else if (answer == "3")
            {
                SaveGoal();
            }

            else if (answer == "4")
            {
                LoadGoal();
            }

            else if (answer == "5")
            {
                RecordEvent();
            }


            else if (answer != "6")
            {
                flagMenu = false;

            }

        } while (answer != "6");

        Console.WriteLine("\nBye-Bye\n");
    }

    public void DisplayPlayerInfo()
    //display points (score) 
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    public void ListGoalNames()
    // display list name goal before recording event(menu 5.)
    {
        Console.WriteLine("The Goals are: ");

        //if goal are completed they don't show in this list

        int i = 1;
        foreach (Goal g in goals)
        {
            if (g.IsComplete() == false)
            {
                Console.WriteLine($"{i}. {g.GetName()}");
            }
            i++;
        }

        Console.WriteLine();
    }

    public void ListGoalDetails()
    //display list of detail goals (menu 2.)
    {
        Console.WriteLine("Your Goals are: ");

        int i = 1;
        foreach (Goal g in goals)
        {
            Console.WriteLine($"{i}. {g.GetStringRepresentation()}");
            i++;
        }

        Console.WriteLine();
    }

    public void CreateGoal()
    //display menu 3 goal
    //1 simple goal : ask name description point
    // 2 eternal goal : ask name description point
    // 3 checklist goal : ask name description point target bonus 
    // if another choice go back to program menu
    // append to list 
    {
        string answer;
        string name;
        string description;
        string points;
        int target;
        int bonus;



        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("     1. Simple Goal");  // 
        Console.WriteLine("     2. Eternal Goal");    // 
        Console.WriteLine("     3. Checklist Goal");         //
        Console.Write("Select a choice from the menu: ");
        answer = Console.ReadLine();

        if (answer != "1" && answer != "2" && answer != "3")
        {
            return;
        }

        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of point associated with this goal? ");
        points = Console.ReadLine();


        if (answer == "1")        // simple
        {
            SimpleGoal mySimple = new SimpleGoal(name, description, points);

            goals.Add(mySimple);
        }

        else if (answer == "2")
        {
            EternalGoal myEternal = new EternalGoal(name, description, points);

            goals.Add(myEternal);
        }

        else if (answer == "3")
        {
            Console.Write("How many times this goal need to be accomplished for a bonus? ");
            target = Int32.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = Int32.Parse(Console.ReadLine());

            ChecklistGoal myChecklist = new ChecklistGoal(name, description, points, target, bonus);

            goals.Add(myChecklist);
        }

        Console.WriteLine();
    }

    public void RecordEvent()
    // display list goal (listgoalname) with number 
    //ask which
    // Congratulations! you have earned {points (+bonus)} points!
    // You have now {_score} points
    //  
    {
        int number;

        ListGoalNames();
        Console.Write("Which Goal did you accomplish? ");
        number = Int32.Parse(Console.ReadLine());

        // utiliser number to get the goal
        Goal myGoal = goals[number - 1];

        myGoal.RecordEvent();

        //ajouter les points
        _score += Int32.Parse(myGoal.GetPoints());

        Console.WriteLine($"You have now {_score} points");

        Console.WriteLine();
    }

    public void SaveGoal()
    // save the list of goal in a txt files 
    // erase and replace if doesn't exist create it 
    {
        Console.Write("In which file do you want to save it (replace)? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal g in goals)
            {
                outputFile.WriteLine(g.GetStringCsv());
            }
        }

        Console.WriteLine($"The Goal is saved in {fileName}");
        Console.WriteLine();
    }

    public void LoadGoal()
    // load goal from txt files
    // erase and replace list of goal 
    {
        string type;
        string name;
        string description;
        string points;
        int completed;
        int target;
        int bonus;

        Console.Write("From which file do you want to load goals? ");
        string fileName = Console.ReadLine();

        using (StreamReader reader = new StreamReader(fileName))
        {
            // vider la list 
            goals.Clear();

            // read score from the first line
            _score = Int32.Parse(reader.ReadLine());

            // Read and process the remaining lines
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Process the line
                string[] parts = line.Split(",");

                type = parts[0];
                name = parts[1];
                description = parts[2];
                points = parts[3];

                if (type == "SimpleGoal")
                {
                    // transform part[4] in int
                    completed = 1;
                    if (parts[4] == "False")
                    {
                        completed = 0;
                    }

                    SimpleGoal mySimple = new SimpleGoal(name, description, points);

                    mySimple.SetComplete(completed);
                    goals.Add(mySimple);
                }

                if (type == "EternalGoal")
                {
                    EternalGoal myEternal = new EternalGoal(name, description, points);

                    goals.Add(myEternal);
                }

                if (type == "ChecklistGoal")
                {
                    bonus = Int32.Parse(parts[4]);
                    target = Int32.Parse(parts[5]);
                    completed = Int32.Parse(parts[6]);

                    ChecklistGoal myChecklist = new ChecklistGoal(name, description, points, target, bonus);

                    myChecklist.SetComplete(completed);
                    goals.Add(myChecklist);
                }
            }
        }

        Console.WriteLine();
    }

}