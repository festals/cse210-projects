using System;

class Program
{
    static void Main(string[] args)
    {

        RunningActivity run = new RunningActivity("05 May 20024", 30, 4.8);

        CyclingActivity cycling = new CyclingActivity("20 Dec 2023", 120, 10);

        SwimmingActivity swim = new SwimmingActivity("15 Feb 2024", 60, 30);

        List<Activity> activity = new List<Activity>{run, cycling, swim};

        foreach(Activity a in activity)
        {
            Console.WriteLine(a.GetSummary());
        }

    }
}