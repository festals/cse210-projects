// "The base class should contain virtual methods for getting the distance, speed, pace. These methods should be overridden in the derived classes."
// So I use virtuals methods and not abstract even if I could and prefer use abstract for those virtual methods 

using System.Diagnostics.Contracts;

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
        return $"{_date} {GetActivity()} ({_length} min)- Distance: {Math.Round(CalculateDistance(),2)} km, Speed: {Math.Round(CalculateSpeed(),2)} kph, Pace: {Math.Round(CalculatePace(),2)} min per km";
    }
    
    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }

    public abstract string GetActivity();
}