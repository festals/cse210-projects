using System.Transactions;

public class Comment
{
    public string _name;     // name of the person who made the comment
    public string _text;     // the comment

        public void DisplayComment()
    {
        Console.WriteLine($"Comment by: {_name} - Comment: {_text}");
    }


}