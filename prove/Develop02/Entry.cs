public class Entry
{
    public string _date;
    public string _promptText;
    public int _entryText;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}