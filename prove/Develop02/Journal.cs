using System.ComponentModel;
using System.IO; 
public class Journal
{
    public List<Entry> entries = new List<Entry>();
 
    public void AddEntry()
    {
        entries.Add(Entry._date);
    }

    public void DisplayAll()
    {
        Console.WriteLine("");
         foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }


    public void LoadFromFile(filename)
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
        }
    }

    public void SaveToFile(List<Entry> entries)
    {
        string filename = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine();
            }
        }
    }


}


