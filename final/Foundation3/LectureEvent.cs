public class LectureEvent : Event
{
    private string _speaker;
    private string _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, string capacity) : base (title,description,date,time,address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetTypeEvent()
    {
        return "Lecture";
    }

    public string FullDetails()
    {
        return $"Lecture: '{_title}' by {_speaker}\n{_description}\nCapacity: {_capacity} seats\nThe {_date} at {_time}\n{GetStrAddress()}";
    }
}