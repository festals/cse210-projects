
public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _fullDetail;
    protected string _type;

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
        return $"Standard Details:\n'{_title}': {_description}\nThe {_date} at {_time}\n{GetStrAddress()}\n";
    }

    public string DisplayShortDescription()
    {
        return $"Short Description: {_type} : '{_title}', the {_date}\n";
    }

    public string DisplayFull()
    {
        return _fullDetail;
    }

}