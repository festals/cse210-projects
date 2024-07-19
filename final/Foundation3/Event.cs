using System.Net.Sockets;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStrAddress()
    {
        return _address.DisplayAddress();
    }


    public string DisplayStdDetails()
    {
        return $"'{_title}': {_description}\nThe {_date} at {_time}\n{_address}";
    }

        public string DisplayShortDescription()
    {
        return $": '{_title}', the {_date}";
    }

}