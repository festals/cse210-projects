public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base (title,description,date,time,address)
    {
        _email = email;
        SetTypeEvent();
        FullDetails();
    }

    public void SetTypeEvent()
    {
        _type = "Reception";
    }


    public void FullDetails()
    {
        _fullDetail = $"Full Details:\nReception: '{_title}':{_description}\nThe {_date} at {_time}\n{GetStrAddress()}\nRSVP at {_email}\n";
    }
}