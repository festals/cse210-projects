using System.ComponentModel;
using System.IO; 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
 
    public void AddEntry()
    {
        Journal.AddEntry(_entries);
    }

    public void DisplayAll()
    {
        Console.WriteLine("");
         foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
}
    string fileName = "myFile.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
    outputFile.WriteLine("This will be the first line in the file.");

