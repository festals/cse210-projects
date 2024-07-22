using System;

class Program
{
    static void Main(string[] args)
    {        
        // creating events
        Address addr1 = new Address("47 St. Johns Road","SOUTHAMPTON","SO21 8QS","United Kingdom");
        Address addr2 = new Address("6861 Walter St","Brown City","Michigan(MI) 48416", "USA");
        Address addr3 = new Address("3649 Derry Rd", "Malton", "Ontario L4T 1A8", "Canada");

        LectureEvent lecture1 = new LectureEvent("The true life of snails", "Snails are often misunderstood creatures, but there is more to them than meets the eye. Did you know they are related to clams, octopi, and squid?\nImagine finding an octopus in your garden! Come to learn more about these incredible creatures.","03/25/2025","9 AM",addr3,"Carl Mefistos","1500");
        ReceptionEvent reception = new ReceptionEvent("Come and sea","A meeting with fellow sea enthusiast and discuss the beauty of the Great and Untameable sea","02/05/2025","2 PM",addr1,"sealover@sea.uk");
        OutdoorEvent outdoor = new OutdoorEvent("The vow renewal of Mr and Ms Smith","To celebrate, after 30 years of blissful marriage, their undiying love for each other in front of all their family and friend","08/15/2024","11 AM",addr2,"sunny 27°C");

        List<Event> events = new List<Event>{lecture1,reception,outdoor};

        // display messages
        Console.Clear();

        int i = 1;
        foreach (Event e in events)
        {
            Console.Write($"---Event number {i}---");
            Console.WriteLine(e.DisplayShortDescription());
            Console.WriteLine(e.DisplayStdDetails());
            Console.WriteLine(e.DisplayFull()); 
            i++; 
        }
    }
}