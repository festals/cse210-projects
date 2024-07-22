using System;

class Program
{
    static void Main(string[] args)
    {
        // create activities in list
        RunningActivity run =     new RunningActivity("05 May 2024", 30, 4.8);
        CyclingActivity cycling = new CyclingActivity("20 Dec 2023", 50, 18);
        SwimmingActivity swim =  new SwimmingActivity("15 Feb 2024", 60, 30);

        List<Activity> activity = new List<Activity>{run, cycling, swim};

        // display summaries
        Console.Clear();

        foreach(Activity a in activity)
        {
            Console.WriteLine(a.GetSummary());
        }

    }
}