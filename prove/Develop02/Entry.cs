public class Entry
{
    public string _date;    //date of the day
    public string _promptText;  //question to display
    public string _entryText;   //response to the question

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText} \n{_entryText}");
    }

    public string StringEntry ()
    {

        return _date+","+_promptText+","+_entryText; 
    }
}