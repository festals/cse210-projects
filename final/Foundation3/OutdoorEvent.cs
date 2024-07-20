public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base (title,description,date,time,address)
    {
        _weather = weather;
    }

    public string GetTypeEvent()
    {
        return "Outdoor";
    }

    public string FullDetails()
    {
        return $"Outdoor: '{_title}':{_description}\nThe {_date} at {_time}\n{GetStrAddress()}\nPlease be aware that it will be {_weather} and dress accordingly.";
    }
}