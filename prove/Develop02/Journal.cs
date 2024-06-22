using System.ComponentModel;
using System.IO; 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
 
    public void AddEntry(Entry lEntry)
    {
        _entries.Add(lEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("");
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }

    public void ClearEntry()
    {
        _entries.Clear();
    }    

    public void LoadFromFile(string fileName, Journal journalLocal)
    {
        string[] fileLines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in fileLines)
        {
            string[] parts = line.Split(",");

            Entry entry1 = new Entry();

            entry1._date = parts[0];
            entry1._promptText = parts[1];
            entry1._entryText = parts[2];

            journalLocal.AddEntry(entry1);

            entry1 = null;
        }
    }

    public void SaveToFileReplace(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e.StringEntry());
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        FileStream ostrm = new FileStream(fileName, FileMode.Append, FileAccess.Write);
        using (StreamWriter outputFile = new StreamWriter(ostrm))
        {              
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e.StringEntry());
            }
        }
    }
}


