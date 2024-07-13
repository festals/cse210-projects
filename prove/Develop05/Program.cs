// for exceeding requierement 
// when Goals are complete they cannot be accomplished again : we don't show them in the list for recordEvent (menu 5)
// And I had a message when you accomplish in totality a checklist Goal with stars
//

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager myManager = new GoalManager();

        Console.Clear();

        myManager.Start();
    }
}



