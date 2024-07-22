public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base (title,description,date,time,address)
    {
        _weather = weather;
        SetTypeEvent();
        FullDetails();
    }

    public void SetTypeEvent()
    {
        _type = "Outdoor";
    }

    public void FullDetails()
    {
        _fullDetail = $"Full Details:\nOutdoor: '{_title}':{_description}\nThe {_date} at {_time}\n{GetStrAddress()}\nPlease be aware that it will be {_weather} and dress accordingly.\n";
    }
}