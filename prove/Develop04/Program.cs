using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string answer;

        do
        {
            Activity myActivity = new Activity();
            BreathingActivity myBreathing = new BreathingActivity();
            ListingActivity myListing = new ListingActivity();
            ReflectingActivity myReflecting = new ReflectingActivity();

            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1.Start breathing activity");  // 
            Console.WriteLine("     2. Start reflecting activity");    // 
            Console.WriteLine("     3. Start listing activity");       // 
            Console.WriteLine("     4. Quit");   //
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                myBreathing.Run();
            }

            if (answer == "2")
            {
                myReflecting.Run();
            }

            if (answer == "3")
            {
                myListing.Run();
            } 

        }while(answer != "4");

    }
}