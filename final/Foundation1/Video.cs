public class Video
{
    public string _title;
    public string _author;
    public string _length;

    public List<Comment> _comments = new List<Comment>();


    public int CommentsNumber()
    {
        return _comments.Count;
    }

    public void AddComment(Comment lEntry)
    {
        _comments.Add(lEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"'{_title}' by {_author} Duration: {_length}s Number of comments: {CommentsNumber()}");
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }

        Console.WriteLine();
    }

}