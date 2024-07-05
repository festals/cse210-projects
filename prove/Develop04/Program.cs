//for exceeding requierement I add at the end of my programm a count of how many time the user spent in each activity


using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        bool flagMenu = true;
        Activity myActivity = new Activity();
        BreathingActivity myBreathing = new BreathingActivity();
        ListingActivity myListing = new ListingActivity();
        ReflectingActivity myReflecting = new ReflectingActivity();

        do
        {
            Console.Clear();
            if (flagMenu == false) 
            {
                Console.WriteLine("You can only type 1, 2, 3 or 4"); 
            }

            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1.Start breathing activity");  // 
            Console.WriteLine("     2. Start reflecting activity");    // 
            Console.WriteLine("     3. Start listing activity");       // 
            Console.WriteLine("     4. Quit");   //
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();
            flagMenu = true;

            if (answer == "1")
            {
                myBreathing.Run();
            }

            else if (answer == "2")
            {
                myReflecting.Run();
            }

            else if (answer == "3")
            {
                myListing.Run();
            } 

            else if (answer !="4")
            {
                flagMenu = false;
               
            }

        }while(answer != "4");

        // display the duration of each activity for this session
        Console.WriteLine($"You have spend {myBreathing.GetTotalDuration()} seconds in Breathing Activity. ");
        Console.WriteLine($"You have spend {myReflecting.GetTotalDuration()} seconds in Reflecting Activity. ");
        Console.WriteLine($"You have spend {myListing.GetTotalDuration()} seconds in Listing Activity. ");
        Console.WriteLine("Bye-Bye");

    }
}