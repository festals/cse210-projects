public abstract class Activity
{
    protected string _date;
    protected double _length;    //in minute

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public string GetSummary()
    {
        return $"{_date} Activity ({_length} min)- Distance: {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }
    
    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();
    
}